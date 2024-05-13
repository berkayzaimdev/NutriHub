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
    public class RemoveCouponCommandHandler : IRequestHandler<RemoveCouponCommand>
    {
        private readonly IRepository<Coupon> _repository;

        public RemoveCouponCommandHandler(IRepository<Coupon> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCouponCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
