using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Commands.CartCommands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.CartHandlers
{
    public class AddCartItemCommandHandler : IRequestHandler<AddCartItemCommand>
    {
        private readonly ICartItemRepository _repository;

        public AddCartItemCommandHandler(ICartItemRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddCartItemCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddToCartAsync(request.ProductId, request.UserId, request.Quantity);
        }
    }
}
