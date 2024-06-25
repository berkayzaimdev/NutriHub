using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Products.Commands;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Models.Requests;

namespace NutriHub.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsAsync(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            var query = new GetProductsQuery(pageNumber, pageSize);
            var values = await _mediator.Send(query);
            _logger.LogWarning("test");
            return Ok(values);
        }

        [HttpGet(Id)]
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
            return Ok();
        }

        [HttpDelete(Id)]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return NoContent();
        }

        [HttpGet("get-product-cards")]
        public async Task<IActionResult> GetProductCardsAsync([FromQuery] int pageNumber = 1, int pageSize = 10)
        {
            var value = await _mediator.Send(new GetProductCardsQuery(UserId, pageNumber, pageSize));
            return Ok(value);
        }

        [HttpGet("get-product-detail/{productId}")]
        public async Task<IActionResult> GetProductDetailAsync(int productId)
        {
            var userId = UserId;
            var value = await _mediator.Send(new GetProductDetailQuery(productId, userId));
            return Ok(value);
        }

        [HttpGet("get-top6-products")]
        public async Task<IActionResult> GetTop10ProductsAsync()
        {
            var values = await _mediator.Send(new GetTop6ProductsQuery());
            return Ok(values);
        }
    }
}
