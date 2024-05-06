using MediatR;
using NutriHub.Application.Abstractions.Interfaces.ProductInterfaces;
using NutriHub.Application.Features.Queries.ProductQueries;
using NutriHub.Application.Features.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.ProductHandlers
{
    public class GetProductDetailsByIdQueryHandler : IRequestHandler<GetProductDetailsByIdQuery, GetProductDetailsByIdQueryResult>
    {
        private readonly IProductRepository _repository;

        public GetProductDetailsByIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetProductDetailsByIdQueryResult> Handle(GetProductDetailsByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductDetailsByIdAsync(request.Id);
            return values.Select();
        }
    }
}
