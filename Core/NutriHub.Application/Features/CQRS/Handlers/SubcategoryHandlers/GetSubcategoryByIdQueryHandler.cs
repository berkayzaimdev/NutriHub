using MediatR;
using NutriHub.Application.Features.CQRS.Queries.CategoryQueries;
using NutriHub.Application.Features.CQRS.Queries.SubcategoryQueries;
using NutriHub.Application.Features.CQRS.Results.CategoryResults;
using NutriHub.Application.Features.CQRS.Results.SubcategoryResults;
using NutriHub.Application.Interfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.SubcategoryHandlers
{
    public class GetSubcategoryByIdQueryHandler : IRequestHandler<GetSubcategoryByIdQuery, GetSubcategoryByIdQueryResult>
    {
        private readonly IRepository<Subcategory> _repository;

        public GetSubcategoryByIdQueryHandler(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }

        public async Task<GetSubcategoryByIdQueryResult> Handle(GetSubcategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetById(request.Id);
            return new GetSubcategoryByIdQueryResult
            {
                Name = value.Name,
                Description = value.Description
            };
        }
    }
}
