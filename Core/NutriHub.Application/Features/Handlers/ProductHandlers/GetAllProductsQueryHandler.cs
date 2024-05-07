﻿using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Queries.ProductQueries;
using NutriHub.Application.Features.Results.ProductResults;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.ProductHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<GetAllProductsQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetAllProductsQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetAllProductsQueryResult>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAllProductsQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}