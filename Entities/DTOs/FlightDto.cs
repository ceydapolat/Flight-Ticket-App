using System.ComponentModel.DataAnnotations;

namespace Entities;

public record FlightDto
{
    public int FlightId { get; init; }

    //[Required(ErrorMessage = "Departure Airport is required.")]
    public string? DepartureAirport { get; init; }

    //[Required(ErrorMessage = "Arrival Airport is required.")]
    public string? ArrivalAirport { get; init; }

    //[Required(ErrorMessage = "Departure Date is required.")]
    public DateOnly DepartureDate { get; init; }

    //[Required(ErrorMessage = "Return Date is required.")]
    public DateOnly ReturnDate { get; init; }
}
