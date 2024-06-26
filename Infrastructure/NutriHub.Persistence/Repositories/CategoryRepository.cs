﻿using Microsoft.EntityFrameworkCore;
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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NutriHubContext _context;

        public CategoryRepository(NutriHubContext context)
        {
            _context = context;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories
                .Include(x => x.Products)
                .ThenInclude(x => x.Brand)
                .Include(x => x.Products)
                .ThenInclude(x => x.Comments)
                .Include(x => x.Subcategories)
                .SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task<List<Category>> GetAllCategoriesWithSubcategoriesAsync()
        {
            return await _context.Categories
                .Include(x => x.Subcategories)
                .ToListAsync();
        }
    }
}
