using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.DTOs.ProductDtos;
using NutriHub.Application.Extensions;
using NutriHub.Application.Features.Categories.Queries;
using NutriHub.Application.Features.Categories.Results;
using NutriHub.Application.Models.Base;
using NutriHub.Application.ViewModels.SubcategoryViewModels;
using NutriHub.Domain.Entities;

namespace NutriHub.Application.Features.Categories.Handlers
{
    public class GetCategoryDetailQueryHandler : IRequestHandler<GetCategoryDetailQuery, GetCategoryDetailQueryResult>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryDetailQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryDetailQueryResult> Handle(GetCategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetCategoryById(request.Id);
            return new GetCategoryDetailQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                Name = value.Name,
                Products = new FilteredResponse<ProductCardDto>(
                    value.Products.LimitByQuery(request.MinPrice, request.MaxPrice).OrderByQuery(request.OrderBy).Select(x => new ProductCardDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Price = x.Price,
                        CardImageUrl = x.CardImageUrl,
                        BrandName = x.Brand.Name,
                        Rating = x.Comments.Any() ? x.Comments.Average(x => x.Rating) : 0
                    }),
                    request.PageNumber,
                    request.PageSize,
                    request.OrderBy
                ),
                Subcategories = value.Subcategories.Select(s => new SubcategoryVM
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description
                })
            };
        }
    }
}
