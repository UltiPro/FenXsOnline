﻿using Classes.Models;
using Classes.Models.User;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAuthMenager _authMenager;
    private readonly IConfiguration _configuration;
    public AccountController(IAuthMenager _authMenager, IConfiguration configuration)
    {
        this._authMenager = _authMenager;
        _configuration = configuration;
    }

    [HttpPost]
    [Route("register")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Register([FromBody] UserRegister userRegister)
    {
        var errors = await _authMenager.Register(userRegister);

        if (errors.Any())
        {
            foreach (var error in errors)
                ModelState.AddModelError(error.Code, error.Description);

            return BadRequest(ModelState);
        }

        return NoContent();
    }

    [HttpPut]
    [Route("login")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Login([FromBody] UserLogin userLogin)
    {
        var authResponse = await _authMenager.Login(userLogin);

        if (authResponse is null)
            return Unauthorized();

        SetHttpOnlyCookie(authResponse, DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])));

        return NoContent();
    }

    [HttpPut]
    [Route("refreshtoken")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RefreshToken()
    {
        var authResponse = new AuthResponse
        {
            Id = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "",
            Token = HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "",
            RefreshToken = HttpContext.Request.Cookies[_configuration["JwtSettings:RefreshTokenCookie"]] ?? ""
        };

        var authResponser = await _authMenager.VerifyRefreshToken(authResponse);

        if (authResponser is null)
            return Unauthorized();

        SetHttpOnlyCookie(authResponser, DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])));

        return NoContent();
    }

    [HttpPut]
    [Route("logout")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult Logout()
    {
        SetHttpOnlyCookie(new AuthResponse
        {
            Id = "",
            Token = "",
            RefreshToken = ""
        }, DateTime.Now);

        return NoContent();
    }

    private void SetHttpOnlyCookie(AuthResponse authResponse, DateTime dateTime)
    {
        HttpContext.Response.Cookies.Append(_configuration["JwtSettings:IdCookie"], authResponse.Id,
            new CookieOptions
            {
                Expires = dateTime,
                HttpOnly = true,
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None
            });
        HttpContext.Response.Cookies.Append(_configuration["JwtSettings:TokenCookie"], authResponse.Token,
            new CookieOptions
            {
                Expires = dateTime,
                HttpOnly = true,
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None
            });
        HttpContext.Response.Cookies.Append(_configuration["JwtSettings:RefreshTokenCookie"], authResponse.RefreshToken,
            new CookieOptions
            {
                Expires = dateTime,
                HttpOnly = true,
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None
            });
    }
}
