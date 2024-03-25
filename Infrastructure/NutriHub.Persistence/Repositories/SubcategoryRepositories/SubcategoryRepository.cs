using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces.SubcategoryInterfaces;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories.SubcategoryRepositories
{
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private readonly NutriHubContext _context;

        public SubcategoryRepository(NutriHubContext context)
        {
            _context = context;
        }
        public async Task<Subcategory> GetSubcategoryWithProductsByIdAsync(int id)
        {
            return await _context.Subcategories
                .Include(x => x.Products)
                .ThenInclude(x => x.Brand)
                .SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}
