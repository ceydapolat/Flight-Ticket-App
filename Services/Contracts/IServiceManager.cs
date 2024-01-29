namespace Services;

public interface IServiceManager
{
    IFlightService FlightService { get; }
    IAirportService AirportService { get; }
}
