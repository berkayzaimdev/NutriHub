﻿using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Persistence.EFCore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.FromResult(_context.Set<T>().AsQueryable());
        }
        public async Task<T> GetById(object id)
        {
            return await _context.Set<T>().FindAsync(id) ?? null;
        }
    }
}
