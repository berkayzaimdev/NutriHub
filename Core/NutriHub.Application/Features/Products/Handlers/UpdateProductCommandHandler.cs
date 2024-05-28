using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Products.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Product>(request);
            value.CardImageUrl = "/productImages/cardImages/355c9d67fa17c7ad6bea34cf4537e824322e6485dac09e1dcc383452e7b1a7f8_card.jpeg";
            value.LargeImageUrl = "/productImages/largeImages/355c9d67fa17c7ad6bea34cf4537e824322e6485dac09e1dcc383452e7b1a7f8_large.jpeg";
            await _repository.UpdateAsync(value);
        }
    }
}
