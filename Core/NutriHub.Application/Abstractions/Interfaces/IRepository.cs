using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        Task DeleteAsync(T entity);
        Task DeleteAllAsync(object[] ids);
        Task DeleteAllAsync(IEnumerable<T> entities);
        Task<IQueryable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T?> GetAsync(object id);
    }
}
