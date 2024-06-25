using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Brands.Queries;
using NutriHub.Application.Features.Queries.BrandQueries;

namespace NutriHub.WebAPI.Controllers
{
    public class BrandsController : ApiController
    {
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveBrandAsync(int id)
        {
            await _mediator.Send(new RemoveBrandCommand(id));
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetBrandsAsync()
        {
            var values = await _mediator.Send(new GetBrandsQuery());
            return Ok(values);
        }

        [HttpGet("brands-menu")]
        public async Task<IActionResult> GetBrandsMenuAsync()
        {
            var values = await _mediator.Send(new GetBrandsMenuQuery());
            return Ok(values);
        }
    }
}
