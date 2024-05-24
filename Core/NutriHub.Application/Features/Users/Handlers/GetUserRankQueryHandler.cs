using MediatR;
using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Features.Users.Queries;
using NutriHub.Application.Features.Users.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Users.Handlers
{
    public class GetUserRankQueryHandler : IRequestHandler<GetUserRankQuery, GetUserRankQueryResult>
    {
        private readonly IPointRepository _pointRepository;
        private readonly IRoleService _roleService;

        public GetUserRankQueryHandler(IPointRepository pointRepository, IRoleService roleService)
        {
            _pointRepository = pointRepository;
            _roleService = roleService;
        }

        public async Task<GetUserRankQueryResult> Handle(GetUserRankQuery request, CancellationToken cancellationToken)
        {
            var points = await _pointRepository.GetUserPointsAsync(request.userId);
            var roleId = await _roleService.GetRoleIdAsync(request.userId);

            return new GetUserRankQueryResult
            {
                Points = points,
                RoleId = roleId
            };
        }
    }
}
