using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Home")]
    [Area("Admin")]
    public class AdminHomeController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
