using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.ProductHandlers
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailQueryResult>
    {
        private readonly IProductRepository _repository;

        public GetProductDetailsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetProductDetailQueryResult> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetProductDetailsByIdAsync(request.Id);
            return new GetProductDetailQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl,

                Rating = value.Comments is not null ? value.Comments.Average(x => x.Rating) : 0,
                
                BrandId = value.Brand.Id,
                BrandName = value.Brand.Name,
                CategoryId = value.Category.Id,
                CategoryName = value.Category.Name,
                SubcategoryId = value.Subcategory.Id,
                SubcategoryName = value.Subcategory.Name,

                Comments = value.Comments
            };
        }
    }
}
