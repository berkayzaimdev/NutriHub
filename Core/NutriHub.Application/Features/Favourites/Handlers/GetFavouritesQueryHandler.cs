using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Favourites.Queries;
using NutriHub.Application.Features.Favourites.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Favourites.Handlers
{
    public class GetFavouritesQueryHandler : IRequestHandler<GetFavouritesQuery, IEnumerable<GetFavouritesQueryResult>>
    {
        private readonly IFavouriteRepository _repository;

        public GetFavouritesQueryHandler(IFavouriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetFavouritesQueryResult>> Handle(GetFavouritesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetFavouritesByUserIdAsync(request.UserId);
            return values.Select(x => new GetFavouritesQueryResult 
            {
                FavouriteId = x.Id,
                Id = x.ProductId,
                Name = x.Product.Name,
                Price = x.Product.Price,
                CardImageUrl = x.Product.CardImageUrl,
                IsInStock = x.Product.Stock > 0
            });
        }
    }
}
