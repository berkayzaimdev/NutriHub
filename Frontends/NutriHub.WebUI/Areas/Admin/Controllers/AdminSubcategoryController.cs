using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Subcategory")]
    [Area("Admin")]
    public class AdminSubcategoryController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
