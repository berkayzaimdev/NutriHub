using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface ICartItemRepository : IRepository<CartItem>
    {
        Task AddToCartAsync(int productId, string userId, int quantity);
        Task<IEnumerable<CartItem>> GetCartItemsByUserIdAsync(string userId);
        Task<decimal> GetCartAmountByUserIdAsync(string userId);
        Task RemoveCartItemsIfOutOfStockAsync(IEnumerable<int> productIds);
    }
}
