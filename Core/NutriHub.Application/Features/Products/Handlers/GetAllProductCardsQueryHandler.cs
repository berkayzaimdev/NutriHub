using MediatR;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.ProductHandlers
{
    public class GetAllProductCardsQueryHandler : IRequestHandler<GetAllProductCardsQuery, IEnumerable<GetAllProductCardsQueryResult>>
    {
        public Task<IEnumerable<GetAllProductCardsQueryResult>> Handle(GetAllProductCardsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
