using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.LayoutViewComponents
{
    public class _AdminHeadComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
