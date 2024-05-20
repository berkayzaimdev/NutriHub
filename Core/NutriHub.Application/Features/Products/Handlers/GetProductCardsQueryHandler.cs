using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Products.Results;
using NutriHub.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Handlers
{
    public class GetProductCardsQueryHandler : IRequestHandler<GetProductCardsQuery, PagedResponse<GetProductCardsQueryResult>>
    {
        private readonly IProductRepository _repository;

        public GetProductCardsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedResponse<GetProductCardsQueryResult>> Handle(GetProductCardsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductCardsAsync(request.UserId);
            var items = values.ApplyPagination(request.PageNumber, request.PageSize);

            return new PagedResponse<GetProductCardsQueryResult>
            (
                items.Select(x => new GetProductCardsQueryResult 
                {
                    Id = x.Product.Id,
                    Name = x.Product.Name,
                    Price = x.Product.Price,
                    CardImageUrl = x.Product.CardImageUrl,
                    BrandId = x.Product.Brand.Id,
                    BrandName = x.Product.Brand.Name,
                    IsFavourited = x.IsFavourited,
                    IsInStock = x.Product.Stock > 0,
                    Rating = x.Product.Comments.Any() ? x.Product.Comments.Average(x => x.Rating) : 0
                }).ToList(),
                request.PageSize,
                request.PageNumber,
                items.Count()
            );
        }
    }
}
