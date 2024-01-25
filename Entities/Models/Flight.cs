using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Flight
{
    public int? FlightId { get; set; }

    //[Required(ErrorMessage = "Departure Airport is required.")]
    public string? DepartureAirport { get; set; }

    //[Required(ErrorMessage = "Arrival Airport is required.")]
    public string? ArrivalAirport { get; set; }

    //[Required(ErrorMessage = "Departure Date is required.")]
    public DateOnly DepartureDate { get; set; }

    //[Required(ErrorMessage = "Return Date is required.")]
    public DateOnly ReturnDate { get; set; }
}
