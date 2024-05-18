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
    public class CouponRepository : Repository<Coupon>, ICouponRepository
    {
        public CouponRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task<Coupon> GetByCodeAsync(string code)
        {
            var values = await GetAllAsync();
            var coupon = await values.SingleOrDefaultAsync(x => x.Code == code);
            return coupon;
        }

        public async Task<decimal> GetDiscountRateAsync(int id)
        {
            var value = await GetAsync(id);
            return value.Discount;
        }
    }
}
