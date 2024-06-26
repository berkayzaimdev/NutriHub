using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Carts.Commands;
using NutriHub.Application.Features.Carts.Queries;
using NutriHub.Application.Models.Requests;
using System.Net;

namespace NutriHub.WebAPI.Controllers
{
    [Authorize]
    public class CartsController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public CartsController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [HttpGet("get-cart-detail")]
        public async Task<IActionResult> GetCartDetail()
        {
            try 
            {
                var userId = _currentUserService.UserId;
                var values = await _mediator.Send(new GetCartDetailQuery(userId));
                _Response.SetStatus(HttpStatusCode.OK);
                _Response.AddData(values);
            }
            catch(Exception ex)
            {
                _Response.SetStatus(HttpStatusCode.Unauthorized);
                _Response.AddError(ex.Message);
                return StatusCode(_Response.Status, _Response.Errors);
            }

            return StatusCode(_Response.Status, _Response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> AddCartItemAsync(AddCartItemRequest request)
        {
            var userId = _currentUserService.UserId;
            await _mediator.Send(new AddCartItemCommand(request.ProductId, request.Quantity, userId));
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
