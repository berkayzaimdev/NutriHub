using MediatR;
using NutriHub.Application.Features.Products.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Queries
{
    public class GetProductCardsQuery : IRequest<IEnumerable<GetProductCardsQueryResult>>
    {
        public string UserId { get; set; }

        public GetProductCardsQuery(string userId)
        {
            UserId = userId;
        }
    }
}
