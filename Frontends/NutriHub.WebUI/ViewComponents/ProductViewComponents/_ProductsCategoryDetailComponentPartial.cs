using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NutriHub.Dto.CategoryDtos;
using NutriHub.Dto.SubcategoryDtos;

namespace NutriHub.WebUI.ViewComponents.ProductViewComponents
{
    public class _ProductsCategoryDetailComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductsCategoryDetailComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id, bool isSubcategory = false)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = new HttpResponseMessage();
            if(isSubcategory)
                responseMessage = await client.GetAsync($"https://localhost:7049/api/Subcategories/{id}");
            else
                responseMessage = await client.GetAsync($"https://localhost:7049/api/Categories/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultCategoryByIdDto>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
