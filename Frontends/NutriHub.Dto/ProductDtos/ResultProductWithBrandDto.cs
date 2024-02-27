using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Dto.ProductDtos
{
    public class ResultProductWithBrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
