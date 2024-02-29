using NutriHub.Application.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.CQRS.Results.SubcategoryResults
{
    public class GetSubcategoryWithProductsByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProductWithBrandVM> Products { get; set; }
    }
}
