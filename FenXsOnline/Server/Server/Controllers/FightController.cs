using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class FightController : AuthBaseController
{
    private readonly IFightMenager _fightMenager;

    public FightController(IConfiguration _configuration, IAuthMenager _authMenager, IFightMenager _fightMenager) : base(_configuration, _authMenager)
    {
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
        return Ok(await _fightMenager.FightMob(await GetCookieUserId(), x, y));
    }
}
