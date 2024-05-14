using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task CreateAllAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateAllAsync(IEnumerable<T> entities);
        Task DeleteAsync(object id);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetById(object id);
    }
}
