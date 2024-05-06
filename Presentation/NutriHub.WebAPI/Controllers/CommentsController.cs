using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Queries.CategoryQueries;
using NutriHub.Application.Features.Queries.CommentQueries;

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



        [HttpGet("GetAllCommentsByAppUserId/{id}")]
        public async Task<IActionResult> GetAllCommentsByAppUserId(string id)
        {
            var values = await _mediator.Send(new GetAllCommentsByAppUserIdQuery(id));
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
