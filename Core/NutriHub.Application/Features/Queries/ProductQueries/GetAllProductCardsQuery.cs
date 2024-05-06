using MediatR;
using NutriHub.Application.Features.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.ProductQueries
{
    public class GetAllProductCardsQuery : IRequest<IEnumerable<GetAllProductCardsQueryResult>>
    {
    }
}
