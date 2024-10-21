using Database.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Server.Extensions;

public class AuthBaseController : ControllerBase
{
    protected readonly IConfiguration _configuration;
    protected readonly IAuthMenager _authMenager;

    public AuthBaseController(IConfiguration _configuration, IAuthMenager _authMenager)
    {
        this._configuration = _configuration;
        this._authMenager = _authMenager;
    }

    protected async Task<string> GetCookieUserId()
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        return cookieId;
    }
}
