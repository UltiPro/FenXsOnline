using Classes.Exceptions;
using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class HeroController : ControllerBase
{
    private readonly IHeroMenager _heroMenager;
    private readonly IAuthMenager _authMenager;
    private readonly IConfiguration _configuration;
    public HeroController(IHeroMenager _heroMenager, IAuthMenager _authMenager, IConfiguration _configuration)
    {
        this._heroMenager = _heroMenager;
        this._authMenager = _authMenager;
        this._configuration = _configuration;
    }

    [HttpGet]
    [Route("name")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> IsAvailableNickname(string name)
    {
        if (!Regex.IsMatch(name, @"^(^[^0-9])([\w a-z A-Z 0-9-_]{2,14})$"))
            throw new BadRequestException("A nickname cannot be shorter than 3 characters and longer than 15 characters.");

        if (await _heroMenager.IsAvailableNickname(name)) return Ok();
        else return Conflict();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Create([FromBody] HeroCreate heroCreate)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        if (await _heroMenager.IsHeroLimitReached(cookieId)) throw new HeroLimitReachedException();
        if (!await _heroMenager.IsAvailableNickname(heroCreate.Name)) return Conflict("This nickname is already taken.");

        return CreatedAtAction(null, await _heroMenager.Create<HeroCreateBackend, HeroBasicInfo>(new HeroCreateBackend(heroCreate, cookieId)));
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Delete(int id)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        if (await _heroMenager.IsHeroThisUser(cookieId, id))
        {
            await _heroMenager.Delete(id);
            return NoContent();
        }

        return Forbid();
    }

    [HttpGet]
    [Route("all")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetAll()
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        return Ok(await _heroMenager.GetHeroes(cookieId));
    }

    [HttpPut]
    [Route("sprite")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> ChangeSprite(int heroId, int spriteLevel)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        if (await _heroMenager.IsHeroThisUser(cookieId, heroId))
        {
            await _heroMenager.ChangeSprite(heroId, spriteLevel);
            return NoContent();
        }

        return Forbid();
    }

    [HttpPut]
    [Route("play")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Play(int id)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        await _heroMenager.Play(cookieId, id);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetInGameHero()
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        return Ok(await _heroMenager.GetInGameHero(cookieId));
    }
}
