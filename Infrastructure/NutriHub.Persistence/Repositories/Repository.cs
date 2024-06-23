using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Exceptions;
using NutriHub.Application.Extensions;
using NutriHub.Persistence.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly NutriHubContext _context;

        public Repository(NutriHubContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task CreateAllAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAllAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(object id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if(entity is null)
            {
                return;
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllAsync(object[] ids)
        {
            var entities = ids.Select(x =>  _context.Set<T>().Find(x)!);

            if(entities.IsNullOrEmpty())
            {
                return;
            }

            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            var query = _context.Set<T>().AsQueryable();

            if (includes != null)
            {
                query = query.IncludeMultiple(includes);
            }

            return await Task.FromResult(query);
        }


        public async Task<T?> GetAsync(object id) => await _context.Set<T>().FindAsync(id);
    }
}
