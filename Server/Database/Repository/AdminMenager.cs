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

    public async Task SetAdminByCode(AdminSetByCode adminSetByCode)
    {
        if (adminSetByCode.Code != _configuration["Settings:AdminCode"]) throw new UnauthorizedException();
        await SetAdmin(adminSetByCode.Id);
    }

    public async Task SetAdmin(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(SetAdmin), id);

        await _userManager.AddToRoleAsync(user, Role.Admin);

        _logger.LogInformation($"A {user.Email} has been promoted to '{Role.Admin}' roles.");
    }

    public async Task UnsetAdmin(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(UnsetAdmin), id);

        await _userManager.RemoveFromRoleAsync(user, Role.Admin);

        _logger.LogInformation($"A {user.Email} has been removed from '{Role.Admin}' roles.");
    }

    public async Task SetModerator(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(SetModerator), id);

        await _userManager.AddToRoleAsync(user, Role.Mod);

        _logger.LogInformation($"A {user.Email} has been promoted to '{Role.Mod}' roles.");
    }

    public async Task UnsetModerator(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(UnsetModerator), id);

        await _userManager.RemoveFromRoleAsync(user, Role.Mod);

        _logger.LogInformation($"A {user.Email} has been removed from '{Role.Mod}' roles.");
    }

    public async Task BanUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(BanUser), id);

        user.IsBanned = true;

        await _userManager.UpdateAsync(user);

        _logger.LogInformation($"A {user.Email} has been banned.");
    }

    public async Task UnbanUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(UnbanUser), id);

        user.IsBanned = false;

        await _userManager.UpdateAsync(user);

        _logger.LogInformation($"A {user.Email} has been unbanned.");
    }
}
