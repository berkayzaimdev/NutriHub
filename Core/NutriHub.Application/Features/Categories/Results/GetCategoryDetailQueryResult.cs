using NutriHub.Application.DTOs.ProductDtos;
using NutriHub.Application.Models.Base;
using NutriHub.Application.ViewModels.ProductViewModels;
using NutriHub.Application.ViewModels.SubcategoryViewModels;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Categories.Results
{
    public class GetCategoryDetailQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FilteredResponse<ProductCardDto> Products { get; set; }
        public IEnumerable<SubcategoryVM> Subcategories { get; set; }
    }
}
