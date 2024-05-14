using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Domain.Entities
{
    public class AppliedCoupon
    {
        public string UserId { get; set; }
        public int CouponId { get; set; }
        public virtual User User { get; set; }
        public virtual Coupon Coupon { get; set; }
    }
}
