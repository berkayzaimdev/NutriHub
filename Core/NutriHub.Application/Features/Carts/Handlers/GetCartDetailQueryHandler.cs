using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.DTOs.CartItemDtos;
using NutriHub.Application.Features.Carts.Queries;
using NutriHub.Application.Features.Carts.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Carts.Handlers
{
    public class GetCartDetailQueryHandler : IRequestHandler<GetCartDetailQuery, GetCartDetailQueryResult>
    {
        private readonly ICartItemRepository _repository;

        public GetCartDetailQueryHandler(ICartItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCartDetailQueryResult> Handle(GetCartDetailQuery request, CancellationToken cancellationToken)
        {
            if(string.IsNullOrEmpty(request.UserId))
            {
                throw new UnauthorizedAccessException();
            }

            var values = await _repository.GetCartItemsByUserIdAsync(request.UserId);

            return new GetCartDetailQueryResult
            {
                CartItems = values.Select(x => new CartItemDto
                {
                    Id = x.Id,
                    ProductId = x.Product.Id,
                    ProductName = x.Product.Name,
                    ProductImageUrl = x.Product.CardImageUrl,

                    BrandName = x.Product.Brand.Name,

                    ProductPrice = x.Product.Price,
                    ProductQuantity = x.Quantity
                }),
                TotalPrice = values.Sum(x => x.Product.Price * x.Quantity),
                TotalQuantity = values.Sum(x => x.Quantity)
            };
        }
    }
}
