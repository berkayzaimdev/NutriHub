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
        public ProductCategoryResponse(List<SubcategoryOfMenuDto> items, int pageNumber, int pageSize, int totalCount, int orderBy) : base(items, pageNumber, pageSize, totalCount, orderBy)
        {
        }
    }
}
