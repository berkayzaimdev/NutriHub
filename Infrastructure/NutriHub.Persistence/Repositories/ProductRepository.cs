using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly NutriHubContext _context;

        public ProductRepository(NutriHubContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsByCategoryId(int categoryId) => await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();


        public async Task<List<Product>> GetProductsByCategoryIdAndSubcategoryId(int categoryId, int subCategoryId) => await _context.Products.Where(p => p.CategoryId == categoryId && p.SubcategoryId == subCategoryId).ToListAsync();


        public async Task<Product> GetProductDetailsByIdAsync(int id) => await _context.Products
                .Include(x => x.Brand)
                .Include(x => x.Category)
                .Include(x => x.Subcategory)
                .FirstOrDefaultAsync(x => x.Id == id);
    }
}
