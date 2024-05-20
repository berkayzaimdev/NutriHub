using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Models
{
    public class Discounts
    {
        public decimal CouponDiscount { get; set; }
        public decimal MembershipDiscount { get; set; }
        public decimal ProductDiscount { get; set; }
        public decimal PaymentMethodDiscount { get; set; }
    }
}
