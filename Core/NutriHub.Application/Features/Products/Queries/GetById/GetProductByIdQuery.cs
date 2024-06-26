using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Features.Products.Queries.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Queries.GetById
{
    public class GetProductByIdQuery : IRequest<ProductByIdResponse>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductByIdResponse>
        {
            private readonly IProductService productService;

            public GetProductByIdQueryHandler(IProductService productService)
            {
                this.productService = productService;
            }

            public async Task<ProductByIdResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                var value = await productService.GetProductByIdAsync(request.Id);
                return new ProductByIdResponse 
                {
                    Id = value.Id,
                    Name = value.Name,
                    Description = value.Description,
                    Price = value.Price,
                    Stock = value.Stock,
                    CardImageUrl = value.CardImageUrl,
                    LargeImageUrl = value.LargeImageUrl,
                    BrandId = value.BrandId,
                    CategoryId = value.CategoryId,
                    SubcategoryId = value.SubcategoryId
                };
            }
        }
    }
}
