using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Application.Features.Favourites.Commands;
using NutriHub.Application.Features.Favourites.Queries;
using NutriHub.Domain.Entities;

namespace NutriHub.WebAPI.Controllers
{
    public class FavouritesController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public FavouritesController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [Authorize]
        [HttpGet("get-favourites-by-user-id")]
        public async Task<IActionResult> GetFavouritesByUserIdAsync()
        {
            var userId = _currentUserService.UserId;
            var query = new GetFavouritesQuery(userId);
            var values = await _mediator.Send(query);
            return Ok(values);
        }

        [Authorize]
        [HttpPost("add-to-favourite/{productId}")]
        public async Task<IActionResult> AddToFavouriteAsync(int productId)
        {
            var userId = _currentUserService.UserId;
            var command = new AddToFavouriteCommand(productId, userId);
            await _mediator.Send(command);
            return Ok("Ürün başarılı bir şekilde favorilere eklendi.");
        }

        [Authorize]
        [HttpPost("remove-from-favourite/{productId}")] // TODO: delete'yi kabul etmedi
        public async Task<IActionResult> RemoveFromFavouriteAsync(int productId)
        {
            var userId = _currentUserService.UserId;
            var command = new RemoveFromFavouriteCommand(productId, userId);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
