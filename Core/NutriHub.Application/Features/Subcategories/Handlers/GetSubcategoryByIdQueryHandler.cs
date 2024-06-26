﻿using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Domain.Entities;
using NutriHub.Application.Features.Subcategories.Queries;
using NutriHub.Application.Features.Subcategories.Results;
using NutriHub.Application.Exceptions;

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
            var value = await _repository.GetAsync(request.Id);

            if(value is null)
            {
                throw new ItemNotFoundException($"Subcategory with ID of {request.Id} is not found.");
            }

            return new GetSubcategoryByIdQueryResult
            {
                Name = value.Name,
                Description = value.Description
            };
        }
    }
}
