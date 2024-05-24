using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Categories.Commands;
using NutriHub.Application.Features.Categories.Queries;

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

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            var values = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByCategoryIdAsync(int id)
        {
            var values = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync(CreateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategoryAsync(UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCategoryAsync(RemoveCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet("get-category-detail/{id}")]
        public async Task<IActionResult> GetCategoryDetailAsync
        (
            [FromRoute] int id,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 9,
            [FromQuery] int orderBy = 1,
            [FromQuery] int minPrice = 0,
            [FromQuery] int maxPrice = 0
        )
        {
            //int pageNumber = 1;
            //int pageSize = 10;
            //int orderBy = 1;
            var values = await _mediator.Send(new GetCategoryDetailQuery(id, pageNumber, pageSize, orderBy, minPrice, maxPrice));
            return Ok(values);
        }

        [HttpGet("GetCategoriesMenu")]
        public async Task<IActionResult> GetCategoriesMenuAsync()
        {
            var values = await _mediator.Send(new GetCategoriesMenuQuery());
            return Ok(values);
        }
    }
}
