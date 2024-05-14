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
    public class AppliedCouponRepository : Repository<AppliedCoupon>, IAppliedCouponRepository
    {
        public AppliedCouponRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task<AppliedCoupon> GetWithCouponAsync(string userId)
        {
            var values = await GetAllAsync();
            var value = await values.Where(x => x.UserId == userId).Include(x => x.Coupon).SingleOrDefaultAsync();
            return value;
        }
    }
}
