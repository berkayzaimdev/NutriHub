using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NutriHub.Dto.ProductDtos;

namespace NutriHub.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("Product/c-{categoryName}-{categoryId}")]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Products/{categoryId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View("Index",values);
            }
            return View();
        }

        [HttpGet("Product/sc-{categoryName}-{categoryId}-{subCategoryId}")]
        public async Task<IActionResult> GetProductsByCategoryAndSubCategory(int categoryId, int subCategoryId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Products/{categoryId}/{subCategoryId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View("Index", values);
            }
            return View();
        }
    }
}
