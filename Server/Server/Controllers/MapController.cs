using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MapController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IAuthMenager _authMenager;
    private readonly IMapMenager _mapMenager;

    public MapController(IConfiguration _configuration, IAuthMenager _authMenager, IMapMenager _mapMenager)
    {
        this._configuration = _configuration;
        this._authMenager = _authMenager;
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
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        return Ok(await _mapMenager.Get(cookieId));
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
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        return Ok(await _mapMenager.GetRefresh(cookieId));
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
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        var result = await _mapMenager.DropItem(cookieId, itemId);

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
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        var result = await _mapMenager.GrabItem(cookieId);

        if (result is null) return NoContent();
        else return Ok(result);
    }
}
