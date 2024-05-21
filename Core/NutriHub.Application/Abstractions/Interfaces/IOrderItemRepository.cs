using MediatR;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
        Task<int> GetProductOrderCountAsync(int productId);
        Task<IEnumerable<OrderItem>> GetWithProductsAsync(int orderId);
    }
}
