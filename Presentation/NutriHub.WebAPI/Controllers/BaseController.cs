using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;

namespace NutriHub.WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        private string UserId { get; set; }

        public BaseController()
        {
            UserId = User.GetUserId();
        }
    }
}
