using NutriHub.Business.Services;
using NutriHub.Dto.CategoryDtos;
using Newtonsoft.Json;
using System.Net.Http;


namespace NutriHub.Business.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryManager(IHttpClientFactory httpClientFactoryy)
        {
            _httpClientFactory = httpClientFactoryy;
        }

        public async Task<ResultCategoryWithProductsAndSubcategoriesDto> GetProductsByCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Categories/GetCategoryByIdWithProductsAndSubcategories/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<ResultCategoryWithProductsAndSubcategoriesDto>(jsonData);
            return value;
        }
    }
}
