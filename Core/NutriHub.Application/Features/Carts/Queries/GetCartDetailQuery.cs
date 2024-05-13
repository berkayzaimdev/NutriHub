using MediatR;
using NutriHub.Application.Features.Carts.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Carts.Queries
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
