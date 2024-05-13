using MediatR;
using NutriHub.Application.Features.Addresses.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Addresses.Queries
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
