namespace Services;

public class ServiceManager : IServiceManager
{
    private IFlightService _flightService;
    private IAirportService _airportService;

    public ServiceManager(IFlightService flightService, IAirportService airportService)
    {
        _flightService = flightService;
        _airportService = airportService;
    }

    public IFlightService FlightService => _flightService;
    public IAirportService AirportService => _airportService;
}
