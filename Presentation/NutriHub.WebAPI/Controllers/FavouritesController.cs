using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Favourites.Commands;
using NutriHub.Application.Features.Favourites.Queries;
using NutriHub.Domain.Entities;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouritesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FavouritesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-favourites-by-user-id")]
        public async Task<IActionResult> GetFavouritesByUserIdAsync()
        {
            var userId = User.GetUserId();
            var command = new GetFavouritesQuery(userId);
            var values = await _mediator.Send(command);
            return Ok(values);
        }

        [HttpPost("add-to-favourite/{productId}")]
        public async Task<IActionResult> AddToFavouriteAsync(int productId)
        {
            var userId = User.GetUserId();
            var command = new AddToFavouriteCommand(productId, userId);
            await _mediator.Send(command);
            return Ok("Ürün başarılı bir şekilde favorilere eklendi.");
        }

        [HttpDelete("remove-from-favourite/{productId}")]
        public async Task<IActionResult> RemoveFromFavouriteAsync(int productId)
        {
            var userId = User.GetUserId();
            var command = new RemoveFromFavouriteCommand(productId, userId);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
