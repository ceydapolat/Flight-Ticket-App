using Microsoft.AspNetCore.Mvc;

namespace FlightTicketApp;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
