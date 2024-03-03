using NutriHub.Dto.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Business.Services
{
    public interface ICategoryService
    {
        Task<ResultCategoryWithProductsAndSubcategoriesDto> GetProductsByCategory(int id);
    }
}
