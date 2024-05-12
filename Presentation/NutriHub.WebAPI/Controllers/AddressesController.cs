using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Commands.AddressCommands;
using NutriHub.Application.Features.Queries.AddressQueries;
using NutriHub.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NutriHub.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly string _userId;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
            _userId = User.GetUserId();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddressAsync(CreateAddressCommand command)
        {
            command.UserId = _userId;
            await _mediator.Send(command);
            return Ok("Address başarılı bir şekilde oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddressAsync(UpdateAddressCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAddressAsync(int id)
        {
            await _mediator.Send(new RemoveAddressCommand(id));
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAddressesByUserIdAsync()
        {
            var values = await _mediator.Send(new GetAddressesByUserIdQuery(_userId));
            return Ok(values);
        }
    }
}
