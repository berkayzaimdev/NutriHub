using MediatR;
using NutriHub.Application.Features.CQRS.Queries.ProductQueries;
using NutriHub.Application.Features.CQRS.Results.ProductResults;
using NutriHub.Application.Interfaces.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductsByCategoryIdAndSubcategoryIdQueryHandler : IRequestHandler<GetProductsByCategoryIdAndSubcategoryIdQuery, List<GetProductsByCategoryIdAndSubcategoryIdQueryResult>>
    {
        private readonly IProductRepository _repository;

        public GetProductsByCategoryIdAndSubcategoryIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductsByCategoryIdAndSubcategoryIdQueryResult>> Handle(GetProductsByCategoryIdAndSubcategoryIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductsByCategoryIdAndSubcategoryId(request.CategoryId, request.SubcategoryId);
            return values.Select(x => new GetProductsByCategoryIdAndSubcategoryIdQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
