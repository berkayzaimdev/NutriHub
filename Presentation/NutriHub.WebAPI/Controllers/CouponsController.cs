using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using NutriHub.Application.Features.Coupons.Commands;
using NutriHub.Application.Features.Coupons.Queries;
using NutriHub.Application.Extensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using NutriHub.Application.Abstractions.Services;

namespace NutriHub.WebAPI.Controllers
{
    public class CouponsController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public CouponsController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
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
                var userId = _currentUserService.UserId;
                var value = await _mediator.Send(new GetAppliedCouponQuery(userId));
                return Ok(value);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize]
        [HttpPost("apply-coupon/{code}")]
        public async Task<IActionResult> ApplyCouponAsync(string code)
        {
            try 
            {
                var userId = _currentUserService.UserId;
                await _mediator.Send(new ApplyCouponCommand(code, userId));
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
            var userId = _currentUserService.UserId;
            await _mediator.Send(new DeapplyCouponCommand(userId));
            return NoContent();
        }
    }

}
