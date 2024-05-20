using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Comments.Commands;
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
        [HttpPost]
        public async Task<IActionResult> CreateCommentAsync(int productId, string description, decimal rating)
        {
            await _mediator.Send(new CreateCommentCommand(UserId,productId, description, rating));
            return Ok();
        }

        [Authorize]
        [HttpGet("get-comments-by-user-id")]
        public async Task<IActionResult> GetCommentsByUserIdAsync()
        {
            var values = await _mediator.Send(new GetCommentsByUserIdQuery(UserId));
            return Ok(values);
        }

        [HttpGet("get-comments-by-product-id/{id}")]
        public async Task<IActionResult> GetCommentsByProductIdAsync(int id)
        {
            var values = await _mediator.Send(new GetCommentsByProductIdQuery(id));
            return Ok(values);
        }

        [Authorize]
        [HttpPost("like-comment")]
        public async Task<IActionResult> LikeCommentAsync(LikeCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [Authorize]
        [HttpPost("dislike-comment")]
        public async Task<IActionResult> DislikeCommentAsync(DislikeCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
