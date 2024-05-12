using MediatR;
using NutriHub.Application.Features.Results.AddressResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.AddressQueries
{
    public class GetAddressesByUserIdQuery : IRequest<IEnumerable<GetAddressesByUserIdQueryResult>>
    {
        public string UserId { get; set; }

        public GetAddressesByUserIdQuery(string userId)
        {
            UserId = userId;
        }
    }
}
