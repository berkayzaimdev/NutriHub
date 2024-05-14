using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Brands.Results;
using NutriHub.Application.Features.Queries.BrandQueries;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Brands.Handlers
{
    public class GetBrandsQueryHandler : IRequestHandler<GetBrandsQuery, IEnumerable<GetBrandsQueryResult>>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetBrandsQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetBrandsQueryResult>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<GetBrandsQueryResult>>(values);
        }
    }
}
