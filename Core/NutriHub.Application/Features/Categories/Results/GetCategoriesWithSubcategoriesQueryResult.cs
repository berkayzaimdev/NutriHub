using NutriHub.Application.DTOs.SubcategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Results
{
    public class GetCategoriesWithSubcategoriesQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IEnumerable<SubcategoryWithDetailsDto> Subcategories { get; set; }
    }
}
