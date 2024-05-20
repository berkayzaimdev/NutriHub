using Azure.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
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
        private readonly IProductRepository _repository;

        public CartItemRepository(NutriHubContext context, IProductRepository repository) : base(context)
        {
            _repository = repository;
        }

        public async Task AddToCartAsync(int productId, string userId, int quantity)
        {
            var product = await _repository.GetAsync(productId);
            if(product.Stock<quantity)
            {
                return; // TODO: exception handling
            }

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

        public async Task<decimal> GetCartAmountByUserIdAsync(string userId)
        {
            var values = await GetAllAsync();
            return await values
                .Include(x => x.Product)
                .Where(x => x.UserId == userId)
                .SumAsync(x => x.Quantity * x.Product.Price);
        }

        public async Task RemoveCartItemsIfOutOfStockAsync(IEnumerable<int> productIds)
        {
            var values = await GetAllAsync();
            values = values.Include(x => x.Product);

            var valuesWithProducts = values
                .Where(x => productIds.Contains(x.ProductId))
                .Where(x => x.Product.Stock < x.Quantity);

            await DeleteAllAsync(valuesWithProducts);
        }
    }
}
