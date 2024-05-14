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
    public class DeapplyCouponCommandHandler : IRequestHandler<DeapplyCouponCommand>
    {
        private readonly IRepository<AppliedCoupon> _repository;

        public DeapplyCouponCommandHandler(IRepository<AppliedCoupon> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeapplyCouponCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.UserId);
        }
    }
}
