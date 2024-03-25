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
    public class GetProductsByCategoryIdQueryHandler : IRequestHandler<GetProductsByCategoryIdQuery, List<GetProductsByCategoryIdQueryResult>>
    {
        private readonly IProductRepository _repository;

        public GetProductsByCategoryIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductsByCategoryIdQueryResult>> Handle(GetProductsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductsByCategoryId(request.CategoryId);
            return values.Select(x => new GetProductsByCategoryIdQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
