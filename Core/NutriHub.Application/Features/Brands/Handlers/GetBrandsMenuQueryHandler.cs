using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Brands.Queries;
using NutriHub.Application.Features.Brands.Results;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Brands.Handlers
{
    public class GetBrandsMenuQueryHandler : IRequestHandler<GetBrandsMenuQuery, IEnumerable<GetBrandsMenuQueryResult>>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetBrandsMenuQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetBrandsMenuQueryResult>> Handle(GetBrandsMenuQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<GetBrandsMenuQueryResult>>(values);
        }
    }
}
