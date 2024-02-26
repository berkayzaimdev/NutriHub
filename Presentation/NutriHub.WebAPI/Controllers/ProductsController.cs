using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.CQRS.Commands.ProductCommands;
using NutriHub.Application.Features.CQRS.Queries.ProductQueries;
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
        public async Task<IActionResult> GetProductsList()
        {
            var values = await _mediator.Send(new GetProductsQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Product başarılı bir şekilde oluşturuldu.");
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetProductsByCategoryIdList(int categoryId)
        {
            var values = await _mediator.Send(new GetProductsByCategoryIdQuery(categoryId));
            return Ok(values);
        }

        [HttpGet("{categoryId}/{subCategoryId}")]
        public async Task<IActionResult> GetProductsByCategoryIdAndSubcategoryIdList(int categoryId, int subCategoryId)
        {
            var values = await _mediator.Send(new GetProductsByCategoryIdAndSubcategoryIdQuery(categoryId, subCategoryId));
            return Ok(values);
        }
    }
}
