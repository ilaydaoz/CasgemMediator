using CasgemMediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMediator.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public  async Task <IActionResult> Index()
        {
            var values =await _mediator.Send(new GetProductQuery());
            return View(values);
        }
    }
}