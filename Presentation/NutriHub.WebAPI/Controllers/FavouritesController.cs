using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Favourites.Commands;
using NutriHub.Application.Features.Favourites.Queries;
using NutriHub.Domain.Entities;

namespace NutriHub.WebAPI.Controllers
{
    public class FavouritesController : ApiController
    {
        [Authorize]
        [HttpGet("get-favourites-by-user-id")]
        public async Task<IActionResult> GetFavouritesByUserIdAsync()
        {
            var command = new GetFavouritesQuery(UserId);
            var values = await _mediator.Send(command);
            return Ok(values);
        }

        [Authorize]
        [HttpPost("add-to-favourite/{productId}")]
        public async Task<IActionResult> AddToFavouriteAsync(int productId)
        {
            var command = new AddToFavouriteCommand(productId, UserId);
            await _mediator.Send(command);
            return Ok("Ürün başarılı bir şekilde favorilere eklendi.");
        }

        [Authorize]
        [HttpPost("remove-from-favourite/{productId}")] // TODO: delete'yi kabul etmedi
        public async Task<IActionResult> RemoveFromFavouriteAsync(int productId)
        {
            var command = new RemoveFromFavouriteCommand(productId, UserId);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
