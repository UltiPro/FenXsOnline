﻿using Microsoft.AspNetCore.Mvc;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Administrator")]
public class AdminController : ControllerBase
{
    private readonly IAdminMenager _adminMenager;

    public AdminController(IAdminMenager _adminMenager)
    {
        this._adminMenager = _adminMenager;
    }

    [HttpPut]
    [Route("setadmin")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> SetAdmin([FromBody] string id)
    {
        await _adminMenager.SetAdmin(id);
        return Ok();
    }

    [HttpPut]
    [Route("unsetadmin")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UnsetAdmin([FromBody] string id)
    {
        await _adminMenager.UnsetAdmin(id);
        return Ok();
    }

    [HttpPut]
    [Route("setmoderator")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> SetModerator([FromBody] string id)
    {
        await _adminMenager.SetModerator(id);
        return Ok();
    }

    [HttpPut]
    [Route("unsetmoderator")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UnsetModerator([FromBody] string id)
    {
        await _adminMenager.UnsetModerator(id);
        return Ok();
    }

    [HttpPut]
    [Route("banuser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> BanUser([FromBody] string id)
    {
        await _adminMenager.BanUser(id);
        return Ok();
    }

    [HttpPut]
    [Route("unbanuser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UnbanUser([FromBody] string id)
    {
        await _adminMenager.UnbanUser(id);
        return Ok();
    }
}
