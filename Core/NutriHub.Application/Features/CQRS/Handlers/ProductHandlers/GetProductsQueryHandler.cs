using MediatR;
using NutriHub.Application.Features.CQRS.Queries.ProductQueries;
using NutriHub.Application.Features.CQRS.Results.ProductResults;
using NutriHub.Application.Interfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<GetProductsQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductsQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductsQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductsQueryResult 
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
