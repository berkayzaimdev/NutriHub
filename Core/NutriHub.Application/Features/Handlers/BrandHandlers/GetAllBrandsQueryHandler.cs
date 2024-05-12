using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Queries.BrandQueries;
using NutriHub.Application.Features.Results.BrandResults;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.BrandHandlers
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, IEnumerable<GetAllBrandsQueryResult>>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetAllBrandsQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAllBrandsQueryResult>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<GetAllBrandsQueryResult>>(values);
        }
    }
}
