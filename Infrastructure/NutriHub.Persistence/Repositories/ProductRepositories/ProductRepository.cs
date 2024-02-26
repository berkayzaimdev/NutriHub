using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Interfaces.ProductInterfaces;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly NutriHubContext _context;

        public ProductRepository(NutriHubContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsByCategoryId(int categoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryIdAndSubcategoryId(int categoryId, int subCategoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId && p.SubcategoryId == subCategoryId).ToListAsync();
        }
    }
}
