using NutriHub.Application.Models;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Services
{
    public interface IDiscountService
    {
        Task<Discounts> CalculateDiscountsAsync(string userId, PaymentMethod paymentMethod, AppliedCoupon coupon, decimal amount);
    }
}
