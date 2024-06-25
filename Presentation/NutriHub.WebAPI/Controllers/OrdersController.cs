using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.DTOs.OrderDtos;
using NutriHub.Application.Features.Orders.Commands;

namespace NutriHub.WebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IMapper _mapper;

        public OrdersController(IMapper mapper)
        {
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
