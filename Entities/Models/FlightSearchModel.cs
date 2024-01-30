public class FlightSearchModel
{
    public bool IsOneWayTicket { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateOnly DepartureDate { get; set; }
    public DateOnly ReturnDate { get; set; }
}
