using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Commands.ProductCommands;
using NutriHub.Application.Features.Queries.CategoryQueries;
using NutriHub.Application.Features.Queries.ProductQueries;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var values = await _mediator.Send(new GetProductsQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByIdAsync(int id)   
        {
            var value = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Product başarılı bir şekilde oluşturuldu.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return NoContent();
        }

        [HttpGet("GetAllProductCardsAsync")]
        public async Task<IActionResult> GetAllProductCardsAsync()
        {
            var value = await _mediator.Send(new GetAllProductCardsQuery());
            return Ok(value);
        }

        [HttpGet("GetProductDetailsById/{id}")]
        public async Task<IActionResult> GetProductDetailsByIdAsync(int id)
        {
            var value = await _mediator.Send(new GetProductDetailsByIdQuery(id));
            return Ok(value);
        }
    }
}
