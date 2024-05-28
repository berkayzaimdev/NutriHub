using MediatR;
using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Products.Results;
using NutriHub.Application.Models.Base;
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
        private readonly IProductRepository _repository;

        public GetProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedResponse<GetProductsQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync(x => x.Brand, x => x.Category, x => x.Subcategory); // includes with delegate

            return new PagedResponse<GetProductsQueryResult>(values.Select(x => new GetProductsQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CardImageUrl = x.CardImageUrl,
                Price = x.Price,
                Stock = x.Stock,
                BrandId = x.Brand.Id,
                BrandName = x.Brand.Name,
                CategoryId = x.Category.Id,
                CategoryName = x.Category.Name,
                SubcategoryId = x.Subcategory.Id,
                SubcategoryName = x.Subcategory.Name
            }), request.PageNumber, request.PageSize);
        }
    }
}
