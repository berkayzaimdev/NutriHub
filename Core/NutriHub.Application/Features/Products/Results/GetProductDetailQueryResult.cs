using NutriHub.Application.DTOs.CommentDtos;
using NutriHub.Domain.Entities;

namespace NutriHub.Application.Features.Products.Results
{
    public class GetProductDetailQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string LargeImageUrl { get; set; }
        public int Stock { get; set; }

        public decimal Rating { get; set; } = 0;
        public int FavouriteCount { get; set; } = 0;
        public int OrderCount { get; set; } = 0;

        public bool IsFavourited { get; set; } = false;
        public bool IsInStock { get; set; } = true;

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }

        public IEnumerable<GetCommentsByProductDto> Comments { get; set; }
        public int CommentsCount { get; set; }
    }
}
