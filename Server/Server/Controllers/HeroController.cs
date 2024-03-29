﻿using Classes.Exceptions;
using Classes.Exceptions.Game.Hero;
using Classes.Models.Game.Hero;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;
using System.Text.RegularExpressions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class HeroController : AuthBaseController
{
    private readonly IHeroMenager _heroMenager;

    public HeroController(IConfiguration _configuration, IAuthMenager _authMenager, IHeroMenager _heroMenager) : base(_configuration, _authMenager)
    {
        this._heroMenager = _heroMenager;
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
        var cookieId = await GetCookieUserId();

        if (await _heroMenager.IsHeroLimitReached(cookieId)) throw new HeroLimitReachedException();
        if (!await _heroMenager.IsAvailableNickname(heroCreate.Name)) return Conflict("This nickname is already taken.");

        return CreatedAtAction(null, await _heroMenager.CreateHero(new HeroCreateBackend(heroCreate, cookieId)));
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Delete(int id)
    {
        if (await _heroMenager.IsHeroThisUser(await GetCookieUserId(), id))
        {
            await _heroMenager.DeleteHero(id);
            return NoContent();
        }

        return Forbid();
    }

    [HttpGet]
    [Route("all")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await _heroMenager.GetHeroes(await GetCookieUserId()));
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
        if (await _heroMenager.IsHeroThisUser(await GetCookieUserId(), heroId))
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
        await _heroMenager.Play(await GetCookieUserId(), id);

        return NoContent();
    }

    [HttpPut]
    [Route("leave")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Leave()
    {
        await _heroMenager.Leave(await GetCookieUserId());

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
        return Ok(await _heroMenager.GetInGameHero(await GetCookieUserId()));
    }
}
