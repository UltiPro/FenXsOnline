using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MovementController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IAuthMenager _authMenager;
    private readonly IMovementMenager _movementMenager;

    public MovementController(IConfiguration _configuration, IAuthMenager _authMenager, IMovementMenager _movementMenager)
    {
        this._configuration = _configuration;
        this._authMenager = _authMenager;
        this._movementMenager = _movementMenager;
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Move(int x, int y)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        var newPosition = await _movementMenager.Move(cookieId, x, y);

        if (newPosition is null) return Forbid();

        return Ok(newPosition);
    }
}
