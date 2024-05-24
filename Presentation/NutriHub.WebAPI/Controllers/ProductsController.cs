using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Products.Commands;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Models.Requests;

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
        public async Task<IActionResult> GetProductsAsync([FromQuery] int pageNumber = 1, int pageSize = 10)
        {
            var query = new GetProductsQuery(pageNumber, pageSize);
            var values = await _mediator.Send(query);
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
