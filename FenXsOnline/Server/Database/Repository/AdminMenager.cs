using Classes.Exceptions;
using Classes.Models.User;
using Classes.Statics;
using Database.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Database.Repository;

public class AdminMenager : IAdminMenager
{
    private readonly ILogger<AdminMenager> _logger;
    private readonly UserManager<DBUser> _userManager;

    public AdminMenager(ILogger<AdminMenager> _logger, UserManager<DBUser> _userManager)
    {
        this._logger = _logger;
        this._userManager = _userManager;
    }

    public async Task SetAdmin(string id)
    {
        var user = await FindUser(id);

        await _userManager.AddToRoleAsync(user, Role.Admin);

        _logger.LogInformation($"A {user.Email} has been promoted to '{Role.Admin}' roles.");
    }

    public async Task UnsetAdmin(string id)
    {
        var user = await FindUser(id);

        await _userManager.RemoveFromRoleAsync(user, Role.Admin);

        _logger.LogInformation($"A {user.Email} has been removed from '{Role.Admin}' roles.");
    }

    public async Task SetModerator(string id)
    {
        var user = await FindUser(id);

        await _userManager.AddToRoleAsync(user, Role.Mod);

        _logger.LogInformation($"A {user.Email} has been promoted to '{Role.Mod}' roles.");
    }

    public async Task UnsetModerator(string id)
    {
        var user = await FindUser(id);

        await _userManager.RemoveFromRoleAsync(user, Role.Mod);

        _logger.LogInformation($"A {user.Email} has been removed from '{Role.Mod}' roles.");
    }

    public async Task BanUser(string id)
    {
        var user = await FindUser(id);

        user.IsBanned = true;

        await _userManager.UpdateAsync(user);

        _logger.LogInformation($"A {user.Email} has been banned.");
    }

    public async Task UnbanUser(string id)
    {
        var user = await FindUser(id);

        user.IsBanned = false;

        await _userManager.UpdateAsync(user);

        _logger.LogInformation($"A {user.Email} has been unbanned.");
    }

    private async Task<DBUser> FindUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user is null) throw new NotFoundException(nameof(FindUser), id);

        return user;
    }
}
