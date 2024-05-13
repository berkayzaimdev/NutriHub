using AutoMapper;
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
    public class GetCouponsQueryHandler : IRequestHandler<GetCouponsQuery, IEnumerable<GetCouponsQueryResult>>
    {
        private readonly IRepository<Coupon> _repository;
        private readonly IMapper _mapper;

        public GetCouponsQueryHandler(IRepository<Coupon> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCouponsQueryResult>> Handle(GetCouponsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<GetCouponsQueryResult>>(values);
        }
    }
}
