﻿using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Carts.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Carts.Handlers
{
    public class RemoveCartItemCommandHandler : IRequestHandler<RemoveCartItemCommand>
    {
        private readonly IRepository<CartItem> _repository;

        public RemoveCartItemCommandHandler(IRepository<CartItem> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCartItemCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
