using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces.ProductInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsByCategoryId(int categoryId);
        Task<List<Product>> GetProductsByCategoryIdAndSubcategoryId(int categoryId, int subCategoryId);
    }
}
