using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Comments.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet("GetAllCommentsByUserId/{id}")]
        public async Task<IActionResult> GetAllCommentsByUserId(string id)
        {
            var values = await _mediator.Send(new GetAllCommentsByUserIdQuery(id));
            return Ok(values);
        }

        [HttpGet("GetAllCommentsByProductId/{id}")]
        public async Task<IActionResult> GetAllCommentsByProductId(int id)
        {
            var values = await _mediator.Send(new GetAllCommentsByProductIdQuery(id));
            return Ok(values);
        }
    }
}
