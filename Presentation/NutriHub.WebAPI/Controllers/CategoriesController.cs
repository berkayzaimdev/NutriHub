﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Commands.CategoryCommands;
using NutriHub.Application.Features.Commands.ProductCommands;
using NutriHub.Application.Features.Queries.CategoryQueries;
using NutriHub.Application.Features.Queries.ProductQueries;
using NutriHub.Application.Features.Results.CategoryResults;

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

        [HttpGet("GetCategoryDetail/{id}")]
        public async Task<IActionResult> GetCategoryDetailAsync(int id)
        {
            var values = await _mediator.Send(new GetCategoryDetailQuery(id));
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
