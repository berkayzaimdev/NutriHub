using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories
{
    public class PointRepository : Repository<Point>, IPointRepository
    {
        public PointRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task<int> GetUserPointsAsync(string userId)
        {
            var value = await GetAsync(userId);
            return value.Points;
        }
    }
}
