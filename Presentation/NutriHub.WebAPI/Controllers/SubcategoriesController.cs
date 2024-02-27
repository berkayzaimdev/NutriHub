using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NutriHub.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubcategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
