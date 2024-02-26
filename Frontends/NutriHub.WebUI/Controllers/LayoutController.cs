using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View("_Layout");
        }
    }
}
