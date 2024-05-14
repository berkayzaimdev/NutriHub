using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Coupons.Commands;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Coupons.Handlers
{
    public class ApplyCouponCommandHandler : IRequestHandler<ApplyCouponCommand>
    {
        private readonly IRepository<AppliedCoupon> _repository;
        private readonly ICouponRepository _couponRepository;

        public ApplyCouponCommandHandler(IRepository<AppliedCoupon> repository, ICouponRepository couponRepository)
        {
            _repository = repository;
            _couponRepository = couponRepository;
        }

        public async Task Handle(ApplyCouponCommand request, CancellationToken cancellationToken)
        {
            var value = await _couponRepository.GetByCodeAsync(request.Code);
            await _repository.CreateAsync(new AppliedCoupon 
            {
                CouponId = value.Id,
                UserId = request.UserId,
            });
        }
    }
}
