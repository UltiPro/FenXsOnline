using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class NpcController : AuthBaseController
{
    private readonly INpcMenager _npcMenager;

    public NpcController(IConfiguration _configuration, IAuthMenager _authMenager, INpcMenager _npcMenager) : base(_configuration, _authMenager)
    {
        this._npcMenager = _npcMenager;
    }

    [HttpPut]
    [Route("heal")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Heal(int npcId)
    {
        await _npcMenager.Heal(await GetCookieUserId(), npcId);

        return NoContent();
    }

    [HttpPut]
    [Route("sell")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Sell(int npcId, int itemId)
    {
        return Ok(await _npcMenager.Sell(await GetCookieUserId(), npcId, itemId));
    }

    [HttpPut]
    [Route("buy")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Buy(int npcId, int itemId)
    {
        return Ok(await _npcMenager.Buy(await GetCookieUserId(), npcId, itemId));
    }
}
