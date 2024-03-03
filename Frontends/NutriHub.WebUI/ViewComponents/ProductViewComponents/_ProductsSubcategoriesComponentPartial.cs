using Microsoft.AspNetCore.Mvc;
using NutriHub.Dto.SubcategoryDtos;

namespace NutriHub.WebUI.ViewComponents.ProductViewComponents
{
    public class _ProductsSubcategoriesComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProductsSubcategoriesComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(List<ResultSubcategoryDto> model)
        {
            return View(model);
        }
    }
}
