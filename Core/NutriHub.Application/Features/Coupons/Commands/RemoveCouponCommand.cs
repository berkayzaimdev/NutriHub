using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Commands
{
    public class RemoveCouponCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveCouponCommand(int id)
        {
            Id = id;
        }
    }
}
