using NutriHub.Application.ViewModels.SubcategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Results.CategoryResults
{
    public class GetAllCategoriesWithSubcategoriesQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubcategoryVM> Subcategories { get; set; }
    }
}
