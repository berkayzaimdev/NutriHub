using NutriHub.Application.ViewModels.ProductViewModels;
using NutriHub.Application.ViewModels.SubcategoryViewModels;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Results.CategoryResults
{
    public class GetCategoryDetailQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProductWithBrandVM> Products { get; set; }
        public IEnumerable<SubcategoryVM> Subcategories { get; set; }
    }
}
