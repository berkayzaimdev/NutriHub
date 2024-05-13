using MediatR;
using NutriHub.Application.Features.Coupons.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Queries
{
    public class GetCouponsQuery : IRequest<IEnumerable<GetCouponsQueryResult>>
    {
    }
}
