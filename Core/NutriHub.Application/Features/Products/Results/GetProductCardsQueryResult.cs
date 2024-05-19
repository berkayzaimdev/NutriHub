using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Products.Results
{
    public class GetProductCardsQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public decimal Rating { get; set; } = 0;
        public bool IsFavourited { get; set; } = false;
        public bool IsInStock { get; set; } = true;

        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
