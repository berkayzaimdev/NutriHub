using Microsoft.AspNetCore.Identity;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Enums;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Helpers
{
    public static class AmountHelper
    {
        public static decimal GetMembershipDiscountRate(string roleName)
        {
            switch(roleName) 
            {
                case RoleType.Silver:
                    return 5m;
                case RoleType.Gold:
                    return 10m;
                case RoleType.Star:
                    return 15m;
                default:
                    return 0m;
            }
        }

        public static decimal GetPaymentMethodDiscountRate(PaymentMethod method)
        {
            switch (method)
            {
                case PaymentMethod.Card:
                    return 0;
                case PaymentMethod.CardOnDelivery:
                    return 30;
                case PaymentMethod.CashOnDelivery:
                    return 50;
                default:
                    return 0;
            }
        }
    }
}
