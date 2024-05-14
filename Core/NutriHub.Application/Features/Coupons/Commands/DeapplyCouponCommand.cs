using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Commands
{
    public class DeapplyCouponCommand : IRequest
    {
        public string UserId { get; set; }

        public DeapplyCouponCommand(string userId)
        {
            UserId = userId;
        }
    }
}
