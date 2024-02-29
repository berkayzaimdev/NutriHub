using NutriHub.Dto.SubcategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Dto.CategoryDtos
{
    public class ResultCategoryWithSubcategoriesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ResultSubcategoryOfCategoryDto> Subcategories { get; set; }
        public class ResultSubcategoryOfCategoryDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
