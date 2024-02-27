using NutriHub.Dto.ProductDtos;
using NutriHub.Dto.SubcategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Dto.CategoryDtos
{
    public class ResultCategoryWithProductsAndSubcategoriesDto
    {
        public int Id { get; set; }
        public IEnumerable<ResultProductDto> Products { get; set; }
        public IEnumerable<ResultSubcategoryDto> Subcategories { get; set; }
    }
}
