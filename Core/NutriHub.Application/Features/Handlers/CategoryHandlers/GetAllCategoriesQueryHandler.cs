﻿using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Queries.CategoryQueries;
using NutriHub.Application.Features.Results.CategoryResults;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.CategoryHandlers
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<GetAllCategoriesQueryResult>>
    {
        private readonly IRepository<Category> _repository;

        public GetAllCategoriesQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetAllCategoriesQueryResult>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAllCategoriesQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            });
        }
    }
}
