using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MovementController : AuthBaseController
{
    private readonly IMovementMenager _movementMenager;

    public MovementController(IConfiguration _configuration, IAuthMenager _authMenager, IMovementMenager _movementMenager) : base(_configuration, _authMenager)
    {
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
        var newPosition = await _movementMenager.Move(await GetCookieUserId(), x, y);

        if (newPosition is null) return Forbid();

        return Ok(newPosition);
    }
}
