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
    public class SubcategoryRepository : ISubcategoryRepository
    {
        private readonly IRepository<Subcategory> _repository;

        public SubcategoryRepository(IRepository<Subcategory> repository)
        {
            _repository = repository;
        }

        public async Task<Subcategory> GetSubcategoryWithProductsByIdAsync(int id)
        {
            var values = await _repository.GetAllAsync();
            return await values
                .Include(x => x.Category)
                .Include(x => x.Products)
                    .ThenInclude(p => p.Comments)
                .Include(x => x.Products)
                    .ThenInclude(p => p.Brand)
                .SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}
