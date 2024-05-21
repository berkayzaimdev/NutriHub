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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(NutriHubContext context) : base(context)
        {
        }

        public async Task<Order> GetDetailsAsync(int orderId)
        {
            var values = await GetAllAsync();
            return values
                .Include(x => x.Address)
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.Product)
                .Single(x => x.Id == orderId);
        }
    }
}
