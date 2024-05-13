using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Brands.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Brands.Handlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Brand>(request);
            await _repository.CreateAsync(value);
        }
    }
}
