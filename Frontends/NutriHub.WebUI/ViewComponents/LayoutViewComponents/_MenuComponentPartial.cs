using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NutriHub.Dto.CategoryDtos;

namespace NutriHub.WebUI.ViewComponents.LayoutViewComponents
{
    public class _MenuComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _MenuComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Categories/GetAllCategoriesWithSubcategories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultCategoryWithSubcategoriesDto>>(jsonData);
                return View("/Views/Shared/Components/Layout/_MenuComponentPartial/Default.cshtml", value);
            }
            return View();
        }
    }
}
