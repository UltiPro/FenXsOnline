using Classes.Exceptions.Game;
using Classes.Models.Game.Hero;
using Database.Contracts;
using Database.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class QuestController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IAuthMenager _authMenager;
    private readonly IQuestMenager _questMenager;

    public QuestController(IConfiguration _configuration, IAuthMenager _authMenager ,IQuestMenager _questMenager)
    {
        this._configuration = _configuration;
        this._authMenager = _authMenager;
        this._questMenager = _questMenager;
    }

    [HttpPost]
    [Route("take")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> TakeQuest(int questId)
    {
        var cookieId = HttpContext.Request.Cookies[_configuration["JwtSettings:IdCookie"]] ?? "";

        await _authMenager.VerifyId(cookieId, HttpContext.Request.Cookies[_configuration["JwtSettings:TokenCookie"]] ?? "");

        await _questMenager.TakeQuest(cookieId, questId);

        return NoContent();
    }
}
