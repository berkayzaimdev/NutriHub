using NutriHub.Application.ViewModels.ProductViewModels;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Application.Abstractions.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<(Product, bool)> GetProductDetailByIdAsync(int productId, string? userId);
        Task<IEnumerable<ProductCardViewModel>> GetProductCardsAsync(string? userId);
    }
}
