using NutriHub.Domain.Entities;

namespace NutriHub.Application.Features.Results.ProductResults
{
    public class GetProductDetailQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public decimal Rating { get; set; } = 0;
        public int FavouriteCount { get; set; } = 0;
        public int SelledCount { get; set; } = 0;

        public bool IsInStock { get; set; } = true;

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
