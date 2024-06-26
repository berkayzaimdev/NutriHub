using Newtonsoft.Json;
using NutriHub.Application.Abstractions.Interfaces;
using NutriHub.Application.Abstractions.Services;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Services
{
    public class ProductService(IProductRepository productRepository, RedisCacheService cacheService) : IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly RedisCacheService _cacheService = cacheService;

        public async Task<Product> GetProductByIdAsync(int id)
        {
            string cacheKey = $"product:{id}";
            if (await _cacheService.ExistsAsync(cacheKey))
            {
                string cachedProduct = await _cacheService.GetAsync(cacheKey);
                var value = JsonConvert.DeserializeObject<Product>(cachedProduct);
                return value;
            }

            var product = await _productRepository.GetProductByIdAsync(id);
            if (product != null)
            {
                string serializedProduct = JsonConvert.SerializeObject(product,
                    new JsonSerializerSettings
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    });
                await _cacheService.SetAsync(cacheKey, serializedProduct, TimeSpan.FromMinutes(30)); // TODO: Magic Number will be fixed
            }

            return product;
        }
    }
}
