using AutoMapper;
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
    public class UpdateCouponCommandHandler : IRequestHandler<UpdateCouponCommand>
    {
        private readonly IRepository<Coupon> _repository;
        private readonly IMapper _mapper;

        public UpdateCouponCommandHandler(IRepository<Coupon> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateCouponCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Coupon>(request);
            await _repository.UpdateAsync(value);
        }
    }
}
