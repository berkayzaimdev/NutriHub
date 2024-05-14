using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface IAppliedCouponRepository : IRepository<AppliedCoupon>
    {
        Task<AppliedCoupon> GetWithCouponAsync(string userId);
    }
}
