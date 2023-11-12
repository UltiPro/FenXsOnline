using Classes.Exceptions;
using Classes.Models.Admin;
using Classes.Models.User;
using Classes.Statics;
using Database.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Database.Repository;

public class AdminMenager : IAdminMenager
{
    private readonly UserManager<DBUser> _userManager;
    private readonly IConfiguration _configuration;
    private readonly ILogger<AdminMenager> _logger;

    public AdminMenager(UserManager<DBUser> _userManager, IConfiguration _configuration, ILogger<AdminMenager> _logger)
    {
        this._userManager = _userManager;
        this._configuration = _configuration;
        this._logger = _logger;
    }

    public async Task<bool> SetAdminByCode(AdminSetByCode adminSetByCode)
    {
        if (adminSetByCode.Code != _configuration["Settings:AdminCode"]) throw new UnauthorizedException();
        return await SetAdmin(adminSetByCode.Id);
    }

    public async Task<bool> SetAdmin(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(SetAdmin), id);

        await _userManager.AddToRoleAsync(user, Roles.Admin);

        _logger.LogInformation($"A {user.Email} has been promoted to '{Roles.Admin}' roles.");

        return true;
    }

    public async Task<bool> UnsetAdmin(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(UnsetAdmin), id);

        await _userManager.RemoveFromRoleAsync(user, Roles.Admin);

        _logger.LogInformation($"A {user.Email} has been removed from '{Roles.Admin}' roles.");

        return true;
    }

    public async Task<bool> SetModerator(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(SetModerator), id);

        await _userManager.AddToRoleAsync(user, Roles.Mod);

        _logger.LogInformation($"A {user.Email} has been promoted to '{Roles.Mod}' roles.");

        return true;
    }

    public async Task<bool> UnsetModerator(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(UnsetModerator), id);

        await _userManager.RemoveFromRoleAsync(user, Roles.Mod);

        _logger.LogInformation($"A {user.Email} has been removed from '{Roles.Mod}' roles.");

        return true;
    }

    public async Task<bool> BanUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(BanUser), id);

        user.IsBanned = true;

        await _userManager.UpdateAsync(user);

        _logger.LogInformation($"A {user.Email} has been banned.");

        return true;
    }

    public async Task<bool> UnbanUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(UnbanUser), id);

        user.IsBanned = false;

        await _userManager.UpdateAsync(user);

        _logger.LogInformation($"A {user.Email} has been unbanned.");

        return true;
    }
}
