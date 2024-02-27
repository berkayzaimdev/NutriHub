using MediatR;
using NutriHub.Application.Features.CQRS.Queries.CategoryQueries;
using NutriHub.Application.Features.CQRS.Results.CategoryResults;
using NutriHub.Application.Interfaces.CategoryInterfaces;
using NutriHub.Application.ViewModels.ProductViewModels;
using NutriHub.Application.ViewModels.SubcategoryViewModels;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdWithProductsAndSubcategoriesQueryHandler : IRequestHandler<GetCategoryByIdWithProductsAndSubcategoriesQuery, GetCategoryByIdWithProductsAndSubcategoriesQueryResult>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByIdWithProductsAndSubcategoriesQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdWithProductsAndSubcategoriesQueryResult> Handle(GetCategoryByIdWithProductsAndSubcategoriesQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetCategoryById(request.Id);
            return new GetCategoryByIdWithProductsAndSubcategoriesQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                Name = value.Name,
                Products = value.Products.Select(p => new ProductWithBrandVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    BrandId = p.BrandId,
                    BrandName = p.Brand.Name
                }).ToList(),
                Subcategories = value.Subcategories.Select(s => new SubcategoryVM 
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description
                })
            };
        }
    }
}
