using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Coupons.Queries;
using NutriHub.Application.Features.Coupons.Results;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Handlers
{
    public class GetAppliedCouponQueryHandler : IRequestHandler<GetAppliedCouponQuery, GetAppliedCouponQueryResult>
    {
        private readonly IAppliedCouponRepository _repository;

        public GetAppliedCouponQueryHandler(IAppliedCouponRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAppliedCouponQueryResult> Handle(GetAppliedCouponQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetWithCouponAsync(request.UserId);
            if(value is null) throw new Exception();
            return new GetAppliedCouponQueryResult 
            {
                Code = value.Coupon.Code,
                Discount = value.Coupon.Discount
            };
        }
    }
}
