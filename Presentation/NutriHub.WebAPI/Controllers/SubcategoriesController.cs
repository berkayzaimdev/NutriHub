using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.CQRS.Queries.CategoryQueries;
using NutriHub.Application.Features.CQRS.Queries.SubcategoryQueries;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubcategoryById(int id)
        {
            var values = await _mediator.Send(new GetSubcategoryByIdQuery(id));
            return Ok(values);
        }

        [HttpGet("GetSubcategoryWithProductsById/{id}")]
        public async Task<IActionResult> GetSubcategoryWithProductsById(int id)
        {
            var values = await _mediator.Send(new GetSubcategoryWithProductsByIdQuery(id));
            return Ok(values);
        }
    }
}
