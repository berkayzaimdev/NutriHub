using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.DTOs.OrderDtos;
using NutriHub.Application.Features.Orders.Commands;

namespace NutriHub.WebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;

        public OrdersController(IMapper mapper, ICurrentUserService currentUserService)
        {
            _mapper = mapper;
            _currentUserService = currentUserService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync()
        {
            var userId = _currentUserService.UserId;
            var dto = new CreateOrderCommand
            {
                AddressId = 1,
                PaymentMethod = 0,
                ShippingAmount = 0,
                Note = "",
                UserId = userId
            };

            var command = _mapper.Map<CreateOrderCommand>(dto);
            await _mediator.Send(command);
            return Ok();
        }
    }
}
