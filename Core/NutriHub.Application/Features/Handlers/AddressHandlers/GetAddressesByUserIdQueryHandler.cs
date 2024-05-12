using AutoMapper;
using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Queries.AddressQueries;
using NutriHub.Application.Features.Results.AddressResults;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.AddressHandlers
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
