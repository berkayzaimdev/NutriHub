using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Results
{
    public class GetAppliedCouponQueryResult
    {
        public string Code { get; set; }
        public decimal Discount { get; set; }
    }
}
