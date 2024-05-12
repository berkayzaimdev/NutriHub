using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Commands.BrandCommands;
using NutriHub.Application.Features.Queries.BrandQueries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrandAsync(CreateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok("Brand başarılı bir şekilde oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrandAsync(UpdateBrandCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrandAsync(int id)
        {
            await _mediator.Send(new RemoveBrandCommand(id));
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrandsAsync()
        {
            var values = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(values);
        }
    }
}
