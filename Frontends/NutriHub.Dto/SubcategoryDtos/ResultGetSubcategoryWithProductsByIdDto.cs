using NutriHub.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Dto.SubcategoryDtos
{
    public class ResultGetSubcategoryWithProductsByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ResultProductWithBrandDto> Products { get; set; }
    }
}
