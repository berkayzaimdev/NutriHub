using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Products.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Handlers
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailQueryResult>
    {
        private readonly IProductRepository _repository;

        public GetProductDetailQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetProductDetailQueryResult> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var productAndStatus = await _repository.GetProductDetailByIdAsync(request.ProductId, request.UserId);
            var value = productAndStatus.Item1;
            return new GetProductDetailQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                ImageUrl = value.ImageUrl,

                Rating = value.Comments is not null ? value.Comments.Average(x => x.Rating) : 0,
                IsFavourited = productAndStatus.Item2,
                IsInStock = value.Stock > 0,

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
