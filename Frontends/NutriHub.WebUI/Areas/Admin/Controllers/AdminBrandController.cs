using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Brand")]
    [Area("Admin")]
    public class AdminBrandController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
