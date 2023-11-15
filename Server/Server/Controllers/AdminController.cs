using Microsoft.AspNetCore.Mvc;
using Database.Contracts;
using Microsoft.AspNetCore.Authorization;
using Classes.Models;

namespace Server.Controllers
{
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

        [HttpPost]
        [Route("setadminbycode")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> SetAdmin([FromBody] AdminSetByCode adminSetByCode)
        {
            await _adminMenager.SetAdminByCode(adminSetByCode);
            return Ok();
        }

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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

        [HttpPost]
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
}
