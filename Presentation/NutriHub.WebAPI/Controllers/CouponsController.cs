using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using NutriHub.Application.Features.Coupons.Commands;
using NutriHub.Application.Features.Coupons.Queries;
using NutriHub.Application.Extensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : BaseController
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

        [Authorize]
        [HttpGet("applied-coupon")]
        public async Task<IActionResult> GetAppliedCouponAsync()
        {
            try 
            {
                var value = await _mediator.Send(new GetAppliedCouponQuery(UserId));
                return Ok(value);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost("apply-coupon/{code}")]
        public async Task<IActionResult> ApplyCouponAsync(string code)
        {
            try 
            {
                await _mediator.Send(new ApplyCouponCommand(code, UserId));
                _Response.SetStatus(HttpStatusCode.OK);
            }
            catch (Exception ex) 
            {
                _Response.AddError(ex.Message);
                _Response.SetStatus(HttpStatusCode.NotFound);
            }
            return StatusCode(_Response.Status, _Response);
        }

        [HttpDelete("deaapply-coupon")]
        public async Task<IActionResult> DeapplyCouponAsync()
        {
            await _mediator.Send(new DeapplyCouponCommand(UserId));
            return NoContent();
        }
    }

}
