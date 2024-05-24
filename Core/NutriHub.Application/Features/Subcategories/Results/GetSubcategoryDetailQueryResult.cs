using NutriHub.Application.DTOs.ProductDtos;
using NutriHub.Application.Models.Base;
using NutriHub.Application.ViewModels.ProductViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Features.Subcategories.Results
{
    public class GetSubcategoryDetailQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public FilteredResponse<ProductCardDto> Products { get; set; }
    }
}
