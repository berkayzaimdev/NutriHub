using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Queries.SubcategoryQueries;
using NutriHub.Application.Features.Results.SubcategoryResults;
using NutriHub.Application.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.SubcategoryHandlers
{
    public class GetSubcategoryDetailQueryHandler : IRequestHandler<GetSubcategoryDetailQuery, GetSubcategoryDetailQueryResult>
    {
        private readonly ISubcategoryRepository _repository;

        public GetSubcategoryDetailQueryHandler(ISubcategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetSubcategoryDetailQueryResult> Handle(GetSubcategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetSubcategoryWithProductsByIdAsync(request.Id);
            return new GetSubcategoryDetailQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                Products = value.Products.Select(p => new ProductWithBrandVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    BrandId = p.BrandId,
                    BrandName = p.Brand.Name
                }).ToList()
            };
        }
    }
}
