using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Comments.Commands;
using NutriHub.Application.Features.Comments.Queries;
using NutriHub.Application.Models.Requests;

namespace NutriHub.WebAPI.Controllers
{
    public class CommentsController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public CommentsController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [Authorize]
        [HttpPost("create-comment")]
        public async Task<IActionResult> CreateCommentAsync(CreateCommentRequest request)
        {
            var userId = _currentUserService.UserId;
            await _mediator.Send(new CreateCommentCommand(userId, request.ProductId, request.Description, request.Rating));
            return Ok();
        }

        [Authorize]
        [HttpGet("get-comments-by-user-id")]
        public async Task<IActionResult> GetCommentsByUserIdAsync()
        {
            var userId = _currentUserService.UserId;
            var values = await _mediator.Send(new GetCommentsByUserIdQuery(userId));
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
