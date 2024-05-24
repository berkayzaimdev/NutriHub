using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.DTOs.ProductDtos
{
    public class ProductCardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CardImageUrl { get; set; }
        public string BrandName { get; set; }
        public decimal Rating { get; set; }
    }
}
