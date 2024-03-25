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
    }
}
