using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Products.Commands;
using NutriHub.Application.Features.Products.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var values = await _mediator.Send(new GetAllProductsQuery());
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

        [HttpGet("get-product-cards")]
        public async Task<IActionResult> GetProductCardsAsync()
        {
            var userId = UserId;
            var value = await _mediator.Send(new GetProductCardsQuery(userId));
            return Ok(value);
        }

        [HttpGet("get-product-details/{productId}")]
        public async Task<IActionResult> GetProductDetailsByIdAsync(int productId)
        {
            var userId = UserId;
            var value = await _mediator.Send(new GetProductDetailQuery(productId, userId));
            return Ok(value);
        }
    }
}
