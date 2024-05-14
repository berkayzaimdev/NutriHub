using MediatR;
using NutriHub.Application.Features.Orders.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Orders.Queries
{
    public class GetOrdersQuery : IRequest<IEnumerable<GetOrdersQueryResult>>
    {
        public string UserId { get; set; }

        public GetOrdersQuery(string userId)
        {
            UserId = userId;
        }
    }
}
