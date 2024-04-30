using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Commands.ProductCommands;
using NutriHub.Application.Features.Queries.CategoryQueries;
using NutriHub.Application.Features.Queries.ProductQueries;

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
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(values);
        }

        [HttpGet("GetCategoryByIdWithProductsAndSubcategories/{id}")]
        public async Task<IActionResult> GetByIdWithProductsAndSubcategories(int id)
        {
            var values = await _mediator.Send(new GetCategoryByIdWithProductsAndSubcategoriesQuery(id));
            return Ok(values);
        }

        [HttpGet("GetAllCategoriesWithSubcategories")]
        public async Task<IActionResult> GetAllWithSubcategoriesList()
        {
            var values = await _mediator.Send(new GetAllCategoriesWithSubcategoriesQuery());
            return Ok(values);
        }
    }
}
