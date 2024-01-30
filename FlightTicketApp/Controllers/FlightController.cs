using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace FlightTicketApp;

[ApiController]
[Route("api/[controller]")]
public class FlightController : Controller
{
    private readonly IServiceManager _manager;
    IEnumerable<Airport> _airports;

    public FlightController(IServiceManager manager)
    {
        _manager = manager;
        _airports = _manager.AirportService.GetAllAirports(false);
    }

    public IActionResult Index()
    {
        IEnumerable<Flight> flights = _manager.FlightService.GetAllFlights(false);

        FlightsViewModel fvm = new FlightsViewModel()
        {
            Airports = _airports,
            Flights = flights
        };

        return View(fvm);
    }

    [HttpGet("get/{id}")]
    public IActionResult Get([FromRoute(Name = "id")] int id)
    {
        if (ModelState.IsValid)
        {
            var flightModel = _manager.FlightService.GetOneFlight(id, false);

            var departureAirport = _manager.AirportService.GetOneAirportByCondition(a => a.AirportId.Equals(flightModel.DepartureAirportId), false);
            var arrivalAirport = _manager.AirportService.GetOneAirportByCondition(a => a.AirportId.Equals(flightModel.ArrivalAirportId), false);

            FlightViewModel fvm = new FlightViewModel()
            {
                Airports = _airports,
                Flight = flightModel
            };

            return View(fvm);
        }

        return View();
    }

    [HttpGet("getinboundtrip/{id}")]
    public IActionResult GetInboundTrip([FromRoute(Name = "id")] int id)
    {
        if (ModelState.IsValid)
        {
            var flightModel = _manager.FlightService.GetOneFlight(id, false);

            var departureAirport = _manager.AirportService.GetOneAirportByCondition(a => a.AirportId.Equals(flightModel.DepartureAirportId), false);
            var arrivalAirport = _manager.AirportService.GetOneAirportByCondition(a => a.AirportId.Equals(flightModel.ArrivalAirportId), false);

            FlightViewModel fvm = new FlightViewModel()
            {
                Airports = _airports,
                Flight = flightModel
            };

            return View(fvm);
        }

        return View();
    }

    [HttpGet("getoutboundandinboundticketsdetail/{id}")]
    public IActionResult GetOutboundAndInboundTicketsDetail([FromRoute(Name = "id")] int id)
    {
        if (ModelState.IsValid)
        {
            var flightModel = _manager.FlightService.GetOneFlight(id, false);

            var departureAirport = _manager.AirportService.GetOneAirportByCondition(a => a.AirportId.Equals(flightModel.DepartureAirportId), false);
            var arrivalAirport = _manager.AirportService.GetOneAirportByCondition(a => a.AirportId.Equals(flightModel.ArrivalAirportId), false);

            FlightViewModel fvm = new FlightViewModel()
            {
                Airports = _airports,
                Flight = flightModel
            };

            return View(fvm);
        }

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SearchFlights([FromForm] Airport airport, [FromForm] Flight flight)
    {
        var currentDate = DateOnly.FromDateTime(DateTime.Now);
        var defaultDateOnly = new DateOnly();

        if (flight.DepartureDate.Equals(defaultDateOnly) || flight.ReturnDate.Equals(defaultDateOnly))
        {
            ModelState.AddModelError("Flights", "Please select date.");
            TempData["DateNotGivenErrorMessage"] = "Please select date.";
        }
        else if (flight.DepartureDate < currentDate || flight.ReturnDate < currentDate)
        {
            ModelState.AddModelError("Flights", "Not allowed to enter past date.");
            TempData["PastDateErrorMessage"] = "Not allowed to enter past date.";
        }

        var arrivalAirport = _manager.AirportService.GetOneAirportByCondition(a => a.ArrivalAirport.Equals(airport.ArrivalAirport), false);
        var departureAirport = _manager.AirportService.GetOneAirportByCondition(a => a.DepartureAirport.Equals(airport.DepartureAirport), false);

        if (arrivalAirport.AirportId == departureAirport.AirportId)
        {
            ModelState.AddModelError("Error", "Please enter different airport.");
            TempData["SameAirportsErrorMessage"] = "Please enter different airport.";
        }

        if (ModelState.IsValid)
        {
            var flightModel = _manager.FlightService.GetAllFlightsByCondition(f => f.DepartureAirportId.Equals(departureAirport.AirportId) && f.ArrivalAirportId.Equals(arrivalAirport.AirportId)
                && f.DepartureDate.Equals(flight.DepartureDate) && f.IsOneWayTicket == flight.IsOneWayTicket, false);

            if (!flightModel.Any())
            {
                TempData["NoAvailableFlight"] = "No flights available... Try for different date";
            }

            FlightsViewModel fvm = new FlightsViewModel()
            {
                Airports = _airports,
                Flights = flightModel
            };

            return View("SearchFlights", fvm);
        }

        return RedirectToAction("Index");
    }
}
