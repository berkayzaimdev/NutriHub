using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Product")]
    [Area("Admin")]
    public class AdminProductController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
