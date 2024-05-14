using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Commands
{
    public class ApplyCouponCommand : IRequest
    {
        public string Code { get; set; }
        public string UserId { get; set; }


        public ApplyCouponCommand(string code, string userId)
        {
            Code = code;
            UserId = userId;
        }
    }
}
