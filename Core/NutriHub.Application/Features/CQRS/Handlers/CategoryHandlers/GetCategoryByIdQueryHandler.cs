using MediatR;
using NutriHub.Application.Features.CQRS.Queries.CategoryQueries;
using NutriHub.Application.Features.CQRS.Results.CategoryResults;
using NutriHub.Application.Interfaces;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetById(request.Id);
            return new GetCategoryByIdQueryResult
            {
                Name = value.Name,
                Description = value.Description
            };
        }
    }
}
