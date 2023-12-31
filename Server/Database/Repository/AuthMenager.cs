﻿using AutoMapper;
using Classes.Exceptions;
using Classes.Models;
using Classes.Models.User;
using Database.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Database.Repository;

public class AuthMenager : IAuthMenager
{
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;
    private readonly ILogger<AuthMenager> _logger;
    private readonly UserManager<DBUser> _userManager;

    private readonly string _loginProvider;
    private readonly string _refreshToken;

    private readonly JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

    private DBUser? _user;

    public AuthMenager(IConfiguration _configuration, IMapper _mapper, ILogger<AuthMenager> _logger, UserManager<DBUser> _userManager)
    {
        this._configuration = _configuration;
        this._mapper = _mapper;
        this._logger = _logger;
        this._userManager = _userManager;
        _loginProvider = _configuration["Settings:TokenProvider"];
        _refreshToken = _configuration["Settings:RefreshToken"];
    }

    public async Task<IEnumerable<IdentityError>> Register(UserRegister userRegister)
    {
        var user = _mapper.Map<DBUser>(userRegister);
        user.UserName = userRegister.Login;
        var result = await _userManager.CreateAsync(user, userRegister.Password);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, "User");
            _logger.LogInformation($"Registered new user at email '{user.Email}'.");
        }

        return result.Errors;
    }

    public async Task<AuthResponse> Login(UserLogin userLogin)
    {
        _user = await _userManager.FindByNameAsync(userLogin.Login);
        bool isValidUser = await _userManager.CheckPasswordAsync(_user, userLogin.Password);

        if (!isValidUser || _user is null) return null;

        if (_user.IsBanned) throw new BannedException();

        _logger.LogInformation($"User '{userLogin.Login}' loged in.");

        return new AuthResponse
        {
            Id = _user.Id,
            Token = await GenerateToken(),
            RefreshToken = await RefreshToken()
        };
    }

    private async Task<string> GenerateToken()
    {
        var credentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"])),
            SecurityAlgorithms.HmacSha256);
        var roles = await _userManager.GetRolesAsync(_user);
        var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
        var claims = new List<Claim>()
        {
            new Claim(JwtRegisteredClaimNames.Sub, _user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, _user.Email),
            new Claim("uid", _user.Id)
        }.Union(await _userManager.GetClaimsAsync(_user)).Union(roleClaims);
        var token = new JwtSecurityToken(
            issuer: _configuration["JwtSettings:Issuer"],
            audience: _configuration["JwtSettings:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
            signingCredentials: credentials
            );
        return jwtSecurityTokenHandler.WriteToken(token);
    }

    public async Task<string> RefreshToken()
    {
        await _userManager.RemoveAuthenticationTokenAsync(_user, _loginProvider, _refreshToken);
        var newRefreshToken = await _userManager.GenerateUserTokenAsync(_user, _loginProvider, _refreshToken);
        await _userManager.SetAuthenticationTokenAsync(_user, _loginProvider, _refreshToken, newRefreshToken);
        return newRefreshToken;
    }

    public async Task<AuthResponse> VerifyRefreshToken(AuthResponse authResponse)
    {
        _user = await GetUser(authResponse.Token);

        if (_user is null || _user.Id != authResponse.Id) return null;
        if (_user.IsBanned) throw new BannedException();

        if (await _userManager.VerifyUserTokenAsync(_user, _loginProvider, _refreshToken, authResponse.RefreshToken))
            return new AuthResponse
            {
                Id = _user.Id,
                Token = await GenerateToken(),
                RefreshToken = await RefreshToken()
            };

        await _userManager.UpdateSecurityStampAsync(_user);

        return null;
    }

    public async Task VerifyId(string id, string token)
    {
        _user = await GetUser(token);

        if (_user is null || _user.Id != id) throw new UnauthorizedException("Invalid token, please relogin.");
        if (_user.IsBanned) throw new BannedException();
    }

    private async Task<DBUser> GetUser(string token)
    {
        try
        {
            return await _userManager.FindByEmailAsync(jwtSecurityTokenHandler
                .ReadJwtToken(token).Claims.ToList().FirstOrDefault(c =>
                c.Type == JwtRegisteredClaimNames.Email)?.Value);
        }
        catch
        {
            throw new UnauthorizedException("Invalid token, please relogin.");
        }
    }
}
