using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using NutriHub.Application.Features.Users.Commands;

namespace NutriHub.WebUI.Controllers
{
	public class HomeController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Auth()
		{
			var client = _httpClientFactory.CreateClient();
			var request = new LoginCommand
			{
				Email = "string",
				Password = "string"
			};
			var jsonData = JsonConvert.SerializeObject(request);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var result = await client.PostAsync("https://localhost:7049/api/Users/login", stringContent);
			return RedirectToAction(nameof(Index));
		}
	}
}
