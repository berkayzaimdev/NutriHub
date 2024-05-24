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
    public class GetTop6ProductsQueryHandler : IRequestHandler<GetTop6ProductsQuery, IEnumerable<GetTop6ProductsQueryResult>>
    {
        private readonly IProductRepository _productRepository;

        public GetTop6ProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<GetTop6ProductsQueryResult>> Handle(GetTop6ProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _productRepository.GetProductCardsAsync("");
            return values.OrderBy(x => x.Product.Price).Take(6).Select(x => new GetTop6ProductsQueryResult
            {
                Id = x.Product.Id,
                Name = x.Product.Name,
                BrandName = x.Product.Brand.Name,
                CardImageUrl = x.Product.CardImageUrl,
                Price = x.Product.Price,
                Rating = x.Product.Comments is not null ? x.Product.Comments.Any() ? x.Product.Comments.Average(x => x.Rating) : 0 : 0
            });
        }
    }
}
