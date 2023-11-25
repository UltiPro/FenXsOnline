﻿using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MovementController : ControllerBase
{
    private readonly IMovementMenager _movementMenager;
    private readonly IAuthMenager _authMenager;
    private readonly IConfiguration _configuration;

    public MovementController(IMovementMenager _movementMenager, IAuthMenager _authMenager, IConfiguration _configuration)
    {
        this._movementMenager = _movementMenager;
        this._authMenager = _authMenager;
        this._configuration = _configuration;
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RefreshToken(int x, int y)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        var newPosition = await _movementMenager.Move(cookieId, x, y);

        if (newPosition is null) return Forbid();

        return Ok(newPosition);
    }
}