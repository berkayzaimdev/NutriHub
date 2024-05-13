using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface IFavouriteRepository : IRepository<Favourite>
    {
        Task<bool> IsFavouritedAsync(int productId, string userId);
        Task DeleteFromFavouriteAsync(int productId, string userId);
        Task<IEnumerable<Favourite>> GetFavouritesByUserIdAsync(string userId);
    }
}
