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
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(NutriHubContext context) : base(context)
        {
        }
        public async Task<int> GetProductOrderCountAsync(int productId)
        {
            var values = await GetAllAsync();
            return values.Count(x => x.ProductId == productId);
        }
    }
}
