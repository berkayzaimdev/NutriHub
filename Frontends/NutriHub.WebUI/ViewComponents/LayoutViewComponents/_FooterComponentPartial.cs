using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.ViewComponents.LayoutViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/Layout/_FooterComponentPartial/Default.cshtml");
        }
    }
}
