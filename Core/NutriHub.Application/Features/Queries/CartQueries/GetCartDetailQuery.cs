using MediatR;
using NutriHub.Application.Features.Results.CartResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Queries.CartQueries
{
    public class GetCartDetailQuery : IRequest<GetCartDetailQueryResult>
    {
        public string UserId { get; set; }

        public GetCartDetailQuery(string userId)
        {
            UserId = userId;
        }
    }
}
