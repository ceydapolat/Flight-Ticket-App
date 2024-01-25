using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace FlightTicketApp;

public class FlightController : Controller
{
    private readonly IServiceManager _manager;

    public FlightController(IServiceManager manager)
    {
        _manager = manager;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Get([FromRoute(Name = "id")] int id)
    {
        var model = _manager.FlightService.GetOneFlight(id, false);
        return View(model);
    }

    public IActionResult GetOneFlightByCondition(Flight flight)
    {
        if (ModelState.IsValid)
        {
            var model = _manager.FlightService.Where(f => f.DepartureAirport.Equals(flight.DepartureAirport)
                && f.ArrivalAirport.Equals(flight.ArrivalAirport));

            return View(model);
        }

        return View();
    }
}
