using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NutriHub.Dto.CategoryDtos;
using NutriHub.Dto.ProductDtos;
using NutriHub.Dto.SubcategoryDtos;

namespace NutriHub.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("Product/c-{categoryId}")]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Categories/GetCategoryByIdWithProductsAndSubcategories/{categoryId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultCategoryWithProductsAndSubcategoriesDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet("Product/sc-{subCategoryId}")]
        public async Task<IActionResult> GetProductsByCategoryAndSubCategory(int subCategoryId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Subcategories/GetSubcategoryWithProductsById/{subCategoryId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultGetSubcategoryWithProductsByIdDto>(jsonData);
                return View("GetProductsBySubcategory", values);
            }
            return View();
        }
    }
}
