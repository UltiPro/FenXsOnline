using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MapController : AuthBaseController
{
    private readonly IMapMenager _mapMenager;

    public MapController(IConfiguration _configuration, IAuthMenager _authMenager, IMapMenager _mapMenager) : base(_configuration, _authMenager)
    {
        this._mapMenager = _mapMenager;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Get()
    {
        return Ok(await _mapMenager.Get(await GetCookieUserId()));
    }

    [HttpGet]
    [Route("refresh")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetRefresh()
    {
        return Ok(await _mapMenager.GetRefresh(await GetCookieUserId()));
    }

    [HttpPut]
    [Route("drop")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Drop(int itemId)
    {
        var result = await _mapMenager.DropItem(await GetCookieUserId(), itemId);

        if (result is null) return NoContent();
        else return Ok(result);
    }

    [HttpPut]
    [Route("grab")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Grab()
    {
        var result = await _mapMenager.GrabItem(await GetCookieUserId());

        if (result is null) return NoContent();
        else return Ok(result);
    }
}
