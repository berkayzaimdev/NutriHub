using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Commands
{
    public class UpdateCouponCommand : IRequest
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal Discount { get; set; }
    }
}
