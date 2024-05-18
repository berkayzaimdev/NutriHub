using MediatR;
using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Products.Results;
using NutriHub.Application.Models;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, PagedResponse<GetProductsQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductsQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<PagedResponse<GetProductsQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var totalCount = await values.CountAsync(cancellationToken);
            var items = await values
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PagedResponse<GetProductsQueryResult>(items.Select(x => new GetProductsQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList(), request.PageNumber, request.PageSize, totalCount);
        }
    }
}
