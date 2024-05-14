using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Comments.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : BaseController
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Authorize]
        [HttpGet("get-comments-by-user-id")]
        public async Task<IActionResult> GetCommentsByUserIdAsync()
        {
            var userId = UserId;
            var values = await _mediator.Send(new GetCommentsByUserIdQuery(userId));
            return Ok(values);
        }

        [HttpGet("get-comments-by-product-id/{id}")]
        public async Task<IActionResult> GetCommentsByProductIdAsync(int id)
        {
            var values = await _mediator.Send(new GetCommentsByProductIdQuery(id));
            return Ok(values);
        }
    }
}
