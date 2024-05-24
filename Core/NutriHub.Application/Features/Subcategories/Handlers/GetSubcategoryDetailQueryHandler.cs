using MediatR;
using Microsoft.AspNetCore.Http.Features;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.DTOs.ProductDtos;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Subcategories.Queries;
using NutriHub.Application.Features.Subcategories.Results;
using NutriHub.Application.Models.Base;
using NutriHub.Application.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Handlers.SubcategoryHandlers
{
    public class GetSubcategoryDetailQueryHandler : IRequestHandler<GetSubcategoryDetailQuery, GetSubcategoryDetailQueryResult>
    {
        private readonly ISubcategoryRepository _repository;

        public GetSubcategoryDetailQueryHandler(ISubcategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetSubcategoryDetailQueryResult> Handle(GetSubcategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetSubcategoryWithProductsByIdAsync(request.Id);
            return new GetSubcategoryDetailQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                CategoryId = value.Category.Id,
                CategoryName = value.Category.Name,
                Products = new FilteredResponse<ProductCardDto>
                (
                    value.Products.LimitByQuery(request.MinPrice, request.MaxPrice).OrderByQuery(request.OrderBy).Select(x => new ProductCardDto 
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Price = x.Price,
                        CardImageUrl = x.CardImageUrl,
                        BrandName = x.Brand.Name,
                        Rating = x.Comments is null ? x.Comments.Any() ? x.Comments.Average(x => x.Rating) : 0 : 0
                    }),
                    request.PageNumber,
                    request.PageSize,
                    request.OrderBy
                )
            };
        }
    }
}
