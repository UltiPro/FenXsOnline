using Database;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace Server.Hubs;

public sealed class ChatHub : Hub
{
    private readonly DatabaseContext _context;
    private readonly IConfiguration _configuration;
    private readonly IAuthMenager _authMenager;

    public ChatHub(DatabaseContext _context, IConfiguration _configuration, IAuthMenager _authMenager)
    {
        this._context = _context;
        this._configuration = _configuration;
        this._authMenager = _authMenager;
    }

    [Authorize]
    public async Task SendMessage(string message)
    {
        var context = Context.GetHttpContext();

        if (context is null) return;

        var cookieId = context.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, context.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == cookieId && hero.InGame);

        if (hero is null) return;

        await Clients.All.SendAsync("ReceiveMessage", hero.Name, $"{message}");
    }
}
