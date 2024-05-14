using AutoMapper;
using MediatR;
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

        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync(CreateOrderDto dto)
        {
            var command = _mapper.Map<CreateOrderCommand>(dto);
            command.UserId = UserId;
            await _mediator.Send(command);
            return Ok();
        }
    }
}
