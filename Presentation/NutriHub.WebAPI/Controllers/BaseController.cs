using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Models;

namespace NutriHub.WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        protected string UserId 
        {
            get {
                return User.GetUserId();
            }
        }

        protected ResponseBuilder _Response { get; private set; } = new ResponseBuilder();
    }
}
