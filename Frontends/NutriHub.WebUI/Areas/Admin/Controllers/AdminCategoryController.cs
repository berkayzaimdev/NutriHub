using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Category")]
    [Area("Admin")]
    public class AdminCategoryController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
