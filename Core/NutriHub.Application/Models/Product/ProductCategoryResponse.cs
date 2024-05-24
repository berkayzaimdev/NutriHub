using NutriHub.Application.DTOs.SubcategoryDtos;
using NutriHub.Application.Models.Base;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Models.Product
{
    public class ProductCategoryResponse : FilteredResponse<SubcategoryOfMenuDto>
    {
        public ProductCategoryResponse(IEnumerable<SubcategoryOfMenuDto> items, int pageNumber, int pageSize, int orderBy) : base(items, pageNumber, pageSize, orderBy)
        {
        }
    }
}
