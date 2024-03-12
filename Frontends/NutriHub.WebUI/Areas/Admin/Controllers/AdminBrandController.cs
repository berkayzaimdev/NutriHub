using Microsoft.AspNetCore.Mvc;
using NutriHub.Business.Services;
using NutriHub.Dto.BrandDtos;

namespace NutriHub.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Brand")]
    [Area("Admin")]
    public class AdminBrandController : Controller
    {
        private readonly IBrandService _service;

        public AdminBrandController(IBrandService service)
        {
            _service = service;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAsync();
            return View();
        }

        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandDto createBrandDto)
        {
            _service.CreateAsync(createBrandDto);
            return RedirectToAction("Index", "AdminBrand", new { area = "Admin" });
        }
    }
}
