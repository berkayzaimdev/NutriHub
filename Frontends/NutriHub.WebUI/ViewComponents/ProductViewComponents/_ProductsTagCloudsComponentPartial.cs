using Microsoft.AspNetCore.Mvc;
using NutriHub.Dto.SubcategoryDtos;

namespace NutriHub.WebUI.ViewComponents.ProductViewComponents
{
    public class _ProductsTagCloudsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductsTagCloudsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
