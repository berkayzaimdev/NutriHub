using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.DTOs.OrderDtos;
using NutriHub.Application.Features.Orders.Commands;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrdersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync()
        {
            var dto = new CreateOrderCommand
            {
                AddressId = 1,
                PaymentMethod = 0,
                ShippingAmount = 0,
                Note = "",
                UserId = UserId
            };

            var command = _mapper.Map<CreateOrderCommand>(dto);
            await _mediator.Send(command);
            return Ok();
        }
    }
}
