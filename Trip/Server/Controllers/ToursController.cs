using Microsoft.AspNetCore.Mvc;
using Trip.Application.Tours.Queries.AllToursQuery;
using Trip.Shared.Tours.Queries.AllToursQuery;

namespace Trip.Server.Controllers
{
    [Route("api/tours")]
    public class ToursController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<List<TourForListVm>>> GetAsync()
        {
            var vm = await Mediator.Send(new AllToursQuery());
            return vm;
        }
    }
}
