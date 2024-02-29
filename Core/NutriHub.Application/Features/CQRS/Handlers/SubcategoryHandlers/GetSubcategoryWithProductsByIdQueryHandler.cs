using MediatR;
using NutriHub.Application.Features.CQRS.Queries.SubcategoryQueries;
using NutriHub.Application.Features.CQRS.Results.SubcategoryResults;
using NutriHub.Application.Interfaces.SubcategoryInterfaces;
using NutriHub.Application.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.SubcategoryHandlers
{
    public class GetSubcategoryWithProductsByIdQueryHandler : IRequestHandler<GetSubcategoryWithProductsByIdQuery, GetSubcategoryWithProductsByIdQueryResult>
    {
        private readonly ISubcategoryRepository _repository;

        public GetSubcategoryWithProductsByIdQueryHandler(ISubcategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetSubcategoryWithProductsByIdQueryResult> Handle(GetSubcategoryWithProductsByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetSubcategoryWithProductsByIdAsync(request.Id);
            return new GetSubcategoryWithProductsByIdQueryResult
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
