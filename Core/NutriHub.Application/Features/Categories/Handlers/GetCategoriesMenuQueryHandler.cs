using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.Features.Categories.Queries;
using NutriHub.Application.Features.Categories.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Handlers
{
    public class GetCategoriesMenuQueryHandler : IRequestHandler<GetCategoriesMenuQuery, IEnumerable<GetCategoriesMenuQueryResult>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoriesMenuQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCategoriesMenuQueryResult>> Handle(GetCategoriesMenuQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCategoriesWithSubcategoriesAsync();
            return values.Select(x => new GetCategoriesMenuQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Subcategories = _mapper.Map<IEnumerable<SubcategoryOfMenuDto>>(x.Subcategories)
            });
        }
    }
}
