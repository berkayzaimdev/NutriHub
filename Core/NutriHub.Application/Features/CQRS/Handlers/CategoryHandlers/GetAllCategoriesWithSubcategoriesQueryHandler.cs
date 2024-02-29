using MediatR;
using NutriHub.Application.Features.CQRS.Queries.CategoryQueries;
using NutriHub.Application.Features.CQRS.Results.CategoryResults;
using NutriHub.Application.Interfaces.CategoryInterfaces;
using NutriHub.Application.ViewModels.SubcategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetAllCategoriesWithSubcategoriesQueryHandler : IRequestHandler<GetAllCategoriesWithSubcategoriesQuery, List<GetAllCategoriesWithSubcategoriesQueryResult>>
    {
        private readonly ICategoryRepository _repository;

        public GetAllCategoriesWithSubcategoriesQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllCategoriesWithSubcategoriesQueryResult>> Handle(GetAllCategoriesWithSubcategoriesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCategoriesWithSubcategoriesAsync();
            return values.Select(x => new GetAllCategoriesWithSubcategoriesQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Subcategories = x.Subcategories.Select(y =>
                new SubcategoryVM
                {
                    Id = y.Id,
                    Name = y.Name
                }).ToList()
            }).ToList();
        }
    }
}
