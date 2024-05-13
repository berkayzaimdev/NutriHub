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
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;
        public UpdateBrandCommandHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Brand>(request);
            await _repository.UpdateAsync(value);
        }
    }
}
