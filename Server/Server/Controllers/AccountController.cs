using Classes.Models.Auth;
using Classes.Models.User;
using Database.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAuthMenager _authMenager;
    public AccountController(IAuthMenager _authMenager)
    {
        this._authMenager = _authMenager;
    }

    [HttpPost]
    [Route("register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Register([FromBody] UserRegister userRegister)
    {
        var errors = await _authMenager.Register(userRegister);

        if (errors.Any())
        {
            foreach (var error in errors)
                ModelState.AddModelError(error.Code, error.Description);

            return BadRequest(ModelState);
        }

        return Ok();
    }

    [HttpPost]
    [Route("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Login([FromBody] UserLogin userLogin)
    {
        var authResponse = await _authMenager.Login(userLogin);

        if (authResponse is null)
            return Unauthorized();

        return Ok(authResponse);
    }

    [HttpPost]
    [Route("refreshtoken")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> RefreshToken([FromBody] AuthResponse authResponse)
    {
        var authResponser = await _authMenager.VerifyRefreshToken(authResponse);

        if (authResponser is null)
            return Unauthorized();

        return Ok(authResponser);
    }
}
