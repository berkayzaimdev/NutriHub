using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Categories.Queries;
using NutriHub.Application.Features.Categories.Results;
using NutriHub.Application.ViewModels.ProductViewModels;
using NutriHub.Application.ViewModels.SubcategoryViewModels;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Handlers
{
    public class GetCategoryDetailQueryHandler : IRequestHandler<GetCategoryDetailQuery, GetCategoryDetailQueryResult>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryDetailQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryDetailQueryResult> Handle(GetCategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetCategoryById(request.Id);
            return new GetCategoryDetailQueryResult
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
