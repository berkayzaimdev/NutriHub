using MediatR;
using NutriHub.Application.Features.Favourites.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Favourites.Queries
{
    public class GetFavouritesQuery : IRequest<IEnumerable<GetFavouritesQueryResult>>
    {
        public string UserId { get; set; }

        public GetFavouritesQuery(string userId)
        {
            UserId = userId;
        }
    }
}
