using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Application.Helpers;
using NutriHub.Application.Models;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly UserManager<User> _userManager;

        public DiscountService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Discounts> CalculateDiscountsAsync(string userId, PaymentMethod paymentMethod, AppliedCoupon coupon, decimal amount)
        {
            var discounts = new Discounts();
            var currentAmount = amount;

            if (coupon != null)
            {
                discounts.CouponDiscount = currentAmount * (coupon.Coupon.Discount / 100);
                currentAmount -= discounts.CouponDiscount;
            }

            var role = await GetUserSingleRoleAsync(userId);
            var membershipDiscountRate = AmountHelper.GetMembershipDiscountRate(role);
            if (membershipDiscountRate != 0)
            {
                discounts.MembershipDiscount = currentAmount * (membershipDiscountRate / 100);
                currentAmount -= discounts.MembershipDiscount;
            }

            discounts.ProductDiscount = 50;
            currentAmount -= discounts.ProductDiscount;

            discounts.PaymentMethodDiscount = AmountHelper.GetPaymentMethodDiscountRate(paymentMethod);
            if (currentAmount - discounts.PaymentMethodDiscount < 0)
            {
                discounts.PaymentMethodDiscount = currentAmount;
            }

            return discounts;
        }

        private async Task<string> GetUserSingleRoleAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var roles = await _userManager.GetRolesAsync(user);
            return roles.Any() ? roles[0] : string.Empty;
        }
    }
}
