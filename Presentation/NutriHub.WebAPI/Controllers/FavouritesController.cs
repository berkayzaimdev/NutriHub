using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Favourites.Commands;

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

        [HttpPost]
        public async Task<IActionResult> AddToFavouriteAsync(AddToFavouriteCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün başarılı bir şekilde favorilere eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFromFavouriteAsync(RemoveFromFavouriteCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
