using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Commands.UserCommands;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> IsAuthenticated()
        {
            return Ok(User.Identity.IsAuthenticated);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginCommand command)
        {
            var token = await _mediator.Send(command);
            return Ok(token);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete()
        {
            return NoContent();
        }
    }
}
