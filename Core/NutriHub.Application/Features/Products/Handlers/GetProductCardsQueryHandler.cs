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
    public class GetProductCardsQueryHandler : IRequestHandler<GetProductCardsQuery, IEnumerable<GetProductCardsQueryResult>>
    {
        private readonly IProductRepository _repository;

        public GetProductCardsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetProductCardsQueryResult>> Handle(GetProductCardsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductCardsAsync(request.UserId);
            return values
                .Select(x => new GetProductCardsQueryResult 
                {
                    Id = x.Product.Id,
                    Name = x.Product.Name,
                    Price = x.Product.Price,
                    ImageUrl = x.Product.ImageUrl,
                    BrandId = x.Product.Brand.Id,
                    BrandName = x.Product.Brand.Name,
                    IsFavourited = x.IsFavourited,
                    IsInStock = x.Product.Stock>0,
                    Rating = x.Product.Comments.Any() ? x.Product.Comments.Average(x => x.Rating) : 0
                });
        }
    }
}
