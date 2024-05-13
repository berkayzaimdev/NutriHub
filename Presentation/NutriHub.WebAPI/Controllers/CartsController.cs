using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Carts.Commands;
using NutriHub.Application.Features.Carts.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-cart-detail")]
        public async Task<IActionResult> GetCartDetail()
        {
            var userId = User.GetUserId();
            var values = await _mediator.Send(new GetCartDetailQuery(userId));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddCartItemAsync(int productId, int quantity)
        {
            var userId = User.GetUserId();
            await _mediator.Send(new AddCartItemCommand(productId, quantity, userId));
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCartItemAsync(int id) 
        {
            await _mediator.Send(new RemoveCartItemCommand(id));
            return Ok();
        }
    }
}
