using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Extensions;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class QuestController : AuthBaseController
{
    private readonly IQuestMenager _questMenager;

    public QuestController(IConfiguration _configuration, IAuthMenager _authMenager, IQuestMenager _questMenager) : base(_configuration, _authMenager)
    {
        this._questMenager = _questMenager;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> TakeQuest(int questId)
    {
        await _questMenager.TakeQuest(await GetCookieUserId(), questId);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetQuestsInfo()
    {
        return Ok(await _questMenager.GetQuestsInfo(await GetCookieUserId()));
    }

    [HttpPost]
    [Route("talk")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Talk(int questId)
    {
        return Ok(await _questMenager.TalkOrBring(await GetCookieUserId(), questId));
    }
}
