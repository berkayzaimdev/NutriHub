using NutriHub.Application.DTOs.SubcategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Results
{
    public class GetCategoriesMenuQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SubcategoryOfMenuDto> Subcategories { get; set; }
    }
}
