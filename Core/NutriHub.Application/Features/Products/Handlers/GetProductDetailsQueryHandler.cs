using MediatR;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.DTOs.CommentDtos;
using NutriHub.Application.Exceptions;
using NutriHub.Application.Features.Products.Queries;
using NutriHub.Application.Features.Products.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Handlers
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, GetProductDetailQueryResult>
    {
        private readonly IProductRepository _repository;
        private readonly IFavouriteRepository _favouriteRepository;
        private readonly IOrderItemRepository _orderItemRepository;

        public GetProductDetailQueryHandler(IProductRepository repository, IFavouriteRepository favouriteRepository, IOrderItemRepository orderItemRepository)
        {
            _repository = repository;
            _favouriteRepository = favouriteRepository;
            _orderItemRepository = orderItemRepository;
        }

        public async Task<GetProductDetailQueryResult> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var productAndStatus = await _repository.GetProductDetailAsync(request.ProductId, request.UserId);
            if (productAndStatus.Item1 is null)
            {
                throw new ItemNotFoundException("");
            }

            var value = productAndStatus.Item1;
            return new GetProductDetailQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Description = value.Description,
                Price = value.Price,
                LargeImageUrl = value.LargeImageUrl,
                Stock = value.Stock,

                Rating = value.Comments is not null ? value.Comments.Any() ? value.Comments.Average(x => x.Rating) : 0 : 0,

                FavouriteCount = await _favouriteRepository.GetProductFavouriteCountAsync(request.ProductId),
                OrderCount = await _orderItemRepository.GetProductOrderCountAsync(request.ProductId),

                IsFavourited = productAndStatus.Item2,
                IsInStock = value.Stock > 0,

                BrandId = value.Brand.Id,
                BrandName = value.Brand.Name,

                CategoryId = value.Category.Id,
                CategoryName = value.Category.Name,

                SubcategoryId = value.Subcategory.Id,
                SubcategoryName = value.Subcategory.Name,

                Comments = value.Comments is not null
                ? value.Comments.Select(x => new GetCommentsByProductDto
                {
                    Id = x.Id,
                    CreatedDate = x.CreatedDate,
                    UserName = string.Concat(values: x.User.FirstName + " " + x.User.LastName),
                    Description = x.Description,
                    Like = x.Like,
                    Dislike = x.Dislike,
                    ModifiedDate = x.ModifiedDate,
                    Rating = x.Rating
                })
                : [],

                CommentsCount = value.Comments is null || !value.Comments.Any() ? 0 : value.Comments.Count()
            };
        }
    }
}
