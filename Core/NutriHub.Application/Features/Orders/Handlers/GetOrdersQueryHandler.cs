using MediatR;
using NutriHub.Application.Features.Orders.Queries;
using NutriHub.Application.Features.Orders.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Orders.Handlers
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IEnumerable<GetOrdersQueryResult>>
    {
        public Task<IEnumerable<GetOrdersQueryResult>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
