using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Subcategories.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriesController : BaseController
    {
        private readonly IMediator _mediator;

        public SubcategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubcategoryById([FromRoute] int id)
        {
            var values = await _mediator.Send(new GetSubcategoryByIdQuery(id));
            return Ok(values);
        }

        [HttpGet("get-subcategory-detail/{id}")]
        public async Task<IActionResult> GetSubcategoryDetailAsync
        (
            [FromRoute] int id,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 9,
            [FromQuery] int orderBy = 1,
            [FromQuery] int minPrice = 0,
            [FromQuery] int maxPrice = 0
        )
        {
            var query = new GetSubcategoryDetailQuery(id, pageNumber, pageSize ,orderBy, minPrice, maxPrice);

            var value = await _mediator.Send(query);
            return Ok(value);
        }
    }
}
