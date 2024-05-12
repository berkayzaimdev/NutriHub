using Azure.Core;
using MediatR;
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
    public class CartItemRepository : Repository<CartItem>, ICartItemRepository
    {

        public CartItemRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task AddToCartAsync(int productId, string userId, int quantity)
        {
            var cartItems = await GetAllAsync();
            var value = await cartItems.FirstOrDefaultAsync(x => x.ProductId == productId && x.UserId == userId);

            if (value is null)
            {
                await CreateAsync(new CartItem 
                {
                    ProductId = productId,
                    Quantity = quantity,
                    UserId = userId
                });
            }

            else
            {
                value.Quantity += quantity;

                if(value.Quantity <= 0)
                {
                    await DeleteAsync(value.Id);
                }

                else
                {
                    await UpdateAsync(value);
                }
            }
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsByUserIdAsync(string userId)
        {
            var values = await GetAllAsync();
            return values
                .Include(x => x.Product)
                .ThenInclude(x => x.Brand)
                .Where(x => x.UserId == userId);
        }
    }
}
