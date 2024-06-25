using System;
using Microsoft.AspNetCore.Mvc;
using tutorial8.Services;

namespace tutorial8.Controllers
{
    [Route("api/trips")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly ITripServices _tripServices;

        public TripsController(ITripServices tripServices)
        {
            _tripServices = tripServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrips()
        {
            return Ok(await _tripServices.GetTripsAsync());
        }
    }
}

