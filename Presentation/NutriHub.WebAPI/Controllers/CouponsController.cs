using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using NutriHub.Application.Features.Coupons.Commands;
using NutriHub.Application.Features.Coupons.Queries;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CouponsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCouponsAsync()
        {
            var values = await _mediator.Send(new GetCouponsQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCouponAsync(CreateCouponCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCouponAsync(UpdateCouponCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCouponAsync(RemoveCouponCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }

}
