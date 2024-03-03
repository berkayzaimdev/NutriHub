using Microsoft.AspNetCore.Mvc;
using NutriHub.Dto.ProductDtos;
using NutriHub.Dto.SubcategoryDtos;

namespace NutriHub.WebUI.ViewComponents.ProductViewComponents
{
    public class _ProductsListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductsListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(List<ResultProductWithBrandDto> model)
        {
            return View(model);
        }
    }
}
