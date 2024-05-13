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
    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommand>
    {
        private readonly IRepository<Coupon> _repository;
        private readonly IMapper _mapper;

        public CreateCouponCommandHandler(IRepository<Coupon> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Coupon 
            {
                Code = request.Code,
                Discount = request.Discount
            });
        }
    }
}
