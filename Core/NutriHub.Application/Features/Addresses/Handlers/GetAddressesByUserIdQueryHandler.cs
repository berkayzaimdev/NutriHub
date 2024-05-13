using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Addresses.Queries;
using NutriHub.Application.Features.Addresses.Results;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Addresses.Handlers
{
    public class GetAddressesByUserIdQueryHandler : IRequestHandler<GetAddressesByUserIdQuery, IEnumerable<GetAddressesByUserIdQueryResult>>
    {
        private readonly IAddressRepository _repository;
        private readonly IMapper _mapper;

        public GetAddressesByUserIdQueryHandler(IAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAddressesByUserIdQueryResult>> Handle(GetAddressesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAddressesByUserIdAsync(request.UserId);
            return _mapper.Map<IEnumerable<GetAddressesByUserIdQueryResult>>(values);
        }
    }
}
