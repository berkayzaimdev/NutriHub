using Microsoft.EntityFrameworkCore;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.ViewModels.ProductViewModels;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.EFCore.Context;

namespace NutriHub.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IFavouriteRepository _favouriteRepository;

        public ProductRepository(NutriHubContext context, IFavouriteRepository favouriteRepository) : base(context)
        {
            _favouriteRepository = favouriteRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsByIdsAsync(int[] ids)
        {
            var values = await GetAllAsync();
            return values.Where(x => ids.Contains(x.Id));
        }

        public async Task<(Product, bool)> GetProductDetailByIdAsync(int productId, string? userId)
        {
            var products = await GetAllAsync();
            var isFavourited = await _favouriteRepository.IsFavouritedAsync(productId, userId);
            return (products
                .Include(x => x.Brand)
                .Include(x => x.Category)
                .Include(x => x.Subcategory)
                .Include(x => x.Comments)
                .FirstOrDefault(x => x.Id == productId),
            isFavourited);
        }

        public async Task<IEnumerable<ProductCardViewModel>> GetProductCardsAsync(string? userId)
        {
            var products = await GetAllAsync();

            var productsWithDetail = await products
                .Include(x => x.Brand)
                .Include(x => x.Comments)
                .ToListAsync();

            var productCardTasks = productsWithDetail.Select(async product => new ProductCardViewModel
            {
                Product = product,
                IsFavourited = false
                //IsFavourited = Task.FromResult(await _favouriteRepository.IsFavouritedAsync(product.Id, userId)).Result // TODO: will fixed
            });

            return await Task.WhenAll(productCardTasks);
        }

        public async Task DecreaseStockByCartItemsAsync(Dictionary<int, int> productIdAndQuantities)
        {
            var boughtProducts = await GetProductsByIdsAsync(productIdAndQuantities.Keys.ToArray());
            foreach(var boughtProduct in boughtProducts) 
            {
                boughtProduct.Stock -= productIdAndQuantities[boughtProduct.Id];
                // TODO: removing from other users' cart below stock
            }
            await UpdateAllAsync(boughtProducts);
        }
    }
}
