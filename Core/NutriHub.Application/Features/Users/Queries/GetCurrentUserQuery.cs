using MediatR;
using NutriHub.Application.Features.Users.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Queries
{
    public class GetCurrentUserQuery : IRequest<GetCurrentUserQueryResult>
    {
        public string UserId { get; set; }

        public GetCurrentUserQuery(string userId)
        {
            UserId = userId;
        }
    }
}
