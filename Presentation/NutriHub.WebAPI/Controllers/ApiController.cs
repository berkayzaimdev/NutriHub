using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutriHub.Application.Extensions;
using NutriHub.Application.Models.Base;

namespace NutriHub.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        private IMediator? mediator;

        protected IMediator _mediator
            => mediator ??= HttpContext
                .RequestServices
                .GetService<IMediator>()!;

        protected string UserId 
        {
            get {
                return User.GetUserId();
            }
        }

        protected ResponseBuilder _Response { get; private set; } = new ResponseBuilder();
    }
}
