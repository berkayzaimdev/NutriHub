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
    public class GetCategoriesWithSubcategoriesQueryHandler : IRequestHandler<GetCategoriesWithSubcategoriesQuery, IEnumerable<GetCategoriesWithSubcategoriesQueryResult>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public GetCategoriesWithSubcategoriesQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCategoriesWithSubcategoriesQueryResult>> Handle(GetCategoriesWithSubcategoriesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCategoriesWithSubcategoriesAsync();
            return values.Select(x => new GetCategoriesWithSubcategoriesQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Image = x.ImageUrl,
                Subcategories = _mapper.Map<IEnumerable<SubcategoryWithDetailsDto>>(x.Subcategories)
            });
        }
    }
}
