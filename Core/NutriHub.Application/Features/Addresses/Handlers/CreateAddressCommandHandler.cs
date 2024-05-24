using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Addresses.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Addresses.Handlers
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Address>(request);

            var allAddresses = await _repository.GetAllAsync();
            var address = allAddresses.Where(x => x.UserId == request.UserId).AsNoTracking().FirstOrDefault();
            if(address == null)
            {
                
                await _repository.CreateAsync(value);
            }
            else 
            {
                value.Id = address.Id;
                await _repository.UpdateAsync(value);
            }
        }
    }
}
