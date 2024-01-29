using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Airport
{
    public int AirportId { get; set; }
    [Required(ErrorMessage ="Departure  Airport is required.")]
    public string? DepartureAirport { get; set; }
    [Required(ErrorMessage ="Arrival Airport is required.")]
    public string? ArrivalAirport { get; set; }
}
