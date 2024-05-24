using MediatR;
using NutriHub.Application.Features.Users.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Queries
{
    public class GetUserRankQuery : IRequest<GetUserRankQueryResult>
    {
        public string userId { get; set; }

        public GetUserRankQuery(string userId)
        {
            this.userId = userId;
        }
    }
}
