using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.ViewComponents.LayoutViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/Layout/_HeadComponentPartial/Default.cshtml");
        }
    }
}
