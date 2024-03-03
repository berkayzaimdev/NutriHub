using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.ViewComponents.ProductViewComponents
{
    public class _ProductsFiltersComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductsFiltersComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
