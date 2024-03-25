using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Queries.CategoryQueries;
using NutriHub.Application.Features.Results.CategoryResults;
using NutriHub.Application.Features.Queries.SubcategoryQueries;
using NutriHub.Application.Features.Results.SubcategoryResults;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.SubcategoryHandlers
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
