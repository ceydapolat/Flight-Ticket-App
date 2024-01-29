using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Flight
{
    public int FlightId { get; set; }
    [Required(ErrorMessage ="Departure Airport is required.")]
    public int DepartureAirportId { get; set; }
    [Required(ErrorMessage ="Arrival Airport is required.")]
    public int ArrivalAirportId { get; set; }
    [Required(ErrorMessage ="Departure Date is required.")]
    public DateOnly DepartureDate { get; set; }
    public TimeOnly DepartureTime { get; set; }
    [Required(ErrorMessage ="Return Date is required.")]
    public DateOnly ReturnDate { get; set; }
    public TimeOnly ArrivalTime { get; set; }
    public bool IsOneWayTicket { get; set; }
    public int AvailableSeat { get; set; }
}
