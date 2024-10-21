using Database.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MobController : ControllerBase
{
    private readonly IMobMenager _mobMenager;

    public MobController(IMobMenager _mobMenager)
    {
        this._mobMenager = _mobMenager;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await _mobMenager.GetInfo(id));
    }
}
