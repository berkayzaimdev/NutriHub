using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Users.Commands;
using NutriHub.Application.Features.Users.Queries;

namespace NutriHub.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public UsersController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
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

        [HttpGet("get-current-user")]
        public async Task<IActionResult> GetCurrentUserAsync()
        {
            var userId = _currentUserService.UserId;
            var query = new GetCurrentUserQuery(userId);
            var value = await _mediator.Send(query);
            return Ok(value);
        }

        [HttpGet("get-user-rank")]
        public async Task<IActionResult> GetUserRankAsync()
        {
            var userId = _currentUserService.UserId;
            var query = new GetUserRankQuery(userId);
            var value = await _mediator.Send(query);
            return Ok(value);
        }

        [HttpDelete(Id)]
        public async Task<IActionResult> Delete()
        {
            await _mediator.Send(new RemoveUserCommand(Id));
            return NoContent();
        }
    }
}
