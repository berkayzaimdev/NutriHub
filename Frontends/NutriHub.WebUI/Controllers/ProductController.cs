using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NutriHub.Business.Services;
using NutriHub.Dto.CategoryDtos;
using NutriHub.Dto.ProductDtos;
using NutriHub.Dto.SubcategoryDtos;

namespace NutriHub.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ICategoryService _categoryService;

        public ProductController(IHttpClientFactory httpClientFactory, ICategoryService categoryService)
        {
            _httpClientFactory = httpClientFactory;
            _categoryService = categoryService;
        }

        [HttpGet("Product/c-{categoryId}")]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            var value = await _categoryService.GetProductsByCategory(categoryId);
            return View(value);
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
