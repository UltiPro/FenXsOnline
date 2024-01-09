using Classes.Enums.Game;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class EquipmentController : AuthBaseController
{
    private readonly IEquipmentMenager _equipmentMenager;

    public EquipmentController(IConfiguration _configuration, IAuthMenager _authMenager, IEquipmentMenager _equipmentMenager) : base(_configuration, _authMenager)
    {
        this._equipmentMenager = _equipmentMenager;
    }

    [HttpPut]
    [Route("move-item")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> MoveItem(int fromId, int toId)
    {
        await _equipmentMenager.MoveItem(await GetCookieUserId(), fromId, toId);

        return NoContent();
    }

    [HttpPut]
    [Route("remove-item")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RemoveItem(int slotId)
    {
        await _equipmentMenager.RemoveItem(await GetCookieUserId(), slotId);

        return NoContent();
    }

    [HttpPut]
    [Route("use-item")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UseItem(int slotId)
    {
        var hero = await _equipmentMenager.UseItem(await GetCookieUserId(), slotId);

        return Ok(hero);
    }

    [HttpPut]
    [Route("unuse-item")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UnuseItem(ItemType itemType, int slotId)
    {
        var hero = await _equipmentMenager.UnuseItem(await GetCookieUserId(), itemType, slotId);

        return Ok(hero);
    }
}
