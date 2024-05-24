using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Carts.Commands;
using NutriHub.Application.Features.Carts.Queries;
using NutriHub.Application.Models.Requests;
using System.Net;

namespace NutriHub.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : BaseController
    {
        private readonly IMediator _mediator;

        public CartsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-cart-detail")]
        public async Task<IActionResult> GetCartDetail()
        {
            try 
            {
                var values = await _mediator.Send(new GetCartDetailQuery(UserId));
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
            await _mediator.Send(new AddCartItemCommand(request.ProductId, request.Quantity, UserId));
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
