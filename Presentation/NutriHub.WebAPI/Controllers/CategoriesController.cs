using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.CQRS.Commands.ProductCommands;
using NutriHub.Application.Features.CQRS.Queries.CategoryQueries;
using NutriHub.Application.Features.CQRS.Queries.ProductQueries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var values = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(values);
        }

        [HttpGet("GetCategoryByIdWithProductsAndSubcategories/{id}")]
        public async Task<IActionResult> GetCategoryByIdWithProductsAndSubcategories(int id)
        {
            var values = await _mediator.Send(new GetCategoryByIdWithProductsAndSubcategoriesQuery(id));
            return Ok(values);
        }
    }
}
