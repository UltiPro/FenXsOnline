using Database.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FightController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IAuthMenager _authMenager;
    private readonly IFightMenager _fightMenager;

    public FightController(IConfiguration _configuration, IAuthMenager _authMenager, IFightMenager _fightMenager)
    {
        this._configuration = _configuration;
        this._authMenager = _authMenager;
        this._fightMenager = _fightMenager;
    }

    [HttpPut]
    [Route("mob")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> FightMob(int x, int y)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        var logs = await _fightMenager.FightMob(cookieId, x, y);

        return Ok(logs);
    }
}
