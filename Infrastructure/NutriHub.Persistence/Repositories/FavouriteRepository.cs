using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    public class FavouriteRepository : Repository<Favourite>, IFavouriteRepository
    {
        public FavouriteRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task<bool> IsFavouritedAsync(int productId, string? userId)
        {
            if(userId.IsNullOrEmpty())
            {
                return false;
            }

            else 
            {
                return await GetAllAsync().Result.AnyAsync(x => x.ProductId == productId && x.UserId == userId);
            }
        }
        public async Task DeleteFromFavouriteAsync(int productId, string userId)
        {
            var values = await GetAllAsync();
            var value = await values.SingleAsync(x => x.ProductId == productId && x.UserId == userId);
            await DeleteAsync(value.Id);
        }

        public async Task<IEnumerable<Favourite>> GetFavouritesByUserIdAsync(string userId)
        {
            var values = await GetAllAsync();
            return values.Include(x => x.Product).Where(x => x.UserId == userId);
        }

        public async Task<int> GetProductFavouriteCountAsync(int productId)
        {
            var values = await GetAllAsync();
            return values.Count(x => x.ProductId == productId);
        }
    }
}
