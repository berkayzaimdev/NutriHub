using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string Note { get; set; }
        public decimal Amount { get; set; }
        [Precision(18, 2)]
        public decimal CouponDiscount { get; set; } = 0;
        [Precision(18, 2)]
        public decimal MembershipDiscount { get; set; } = 0;
        [Precision(18, 2)]
        public decimal ProductDiscount { get; set; } = 0;
        [Precision(18, 2)]
        public decimal PaymentMethodDiscount { get; set; } = 0;
        public int EarnedPoints { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DeliveredDate { get; set; }

        public int? CouponId { get; set; }
        public Coupon Coupon { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }
    }

    public enum PaymentMethod
    {
        Card = 0,
        CardOnDelivery = 30,
        CashOnDelivery = 50
    }
}
