using MediatR;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Features.Users.Queries;
using NutriHub.Application.Features.Users.Results;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Handlers
{
    public class GetCurrentUserQueryHandler : IRequestHandler<GetCurrentUserQuery, GetCurrentUserQueryResult>
    {
        private readonly UserManager<User> _manager;

        public GetCurrentUserQueryHandler(UserManager<User> manager)
        {
            _manager = manager;
        }

        public async Task<GetCurrentUserQueryResult> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _manager.FindByIdAsync(request.UserId);
            return new GetCurrentUserQueryResult
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email
            };
        }
    }
}
