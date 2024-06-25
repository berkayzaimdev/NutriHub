using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Addresses.Commands;
using NutriHub.Application.Features.Addresses.Queries;
using NutriHub.Application.Models.Requests;

namespace NutriHub.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateAddressAsync(CreateAddressRequest request)
        {
            var command = new CreateAddressCommand
            {
                Name = request.Name,
                Surname = request.Surname,
                Title =request.Title,
                Description = request.Description,
                Province = request.Province,
                District = request.District,
                Email = request.Email,
                Phone = request.Phone,
                UserId = UserId
            };
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
            var values = await _mediator.Send(new GetAddressesByUserIdQuery(UserId));
            return Ok(values);
        }
    }
}
