using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Subcategories.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubcategoryDetailAsync(int id)
        {
            var values = await _mediator.Send(new GetSubcategoryDetailQuery(id));
            return Ok(values);
        }
    }
}
