namespace Services;

public class ServiceManager : IServiceManager
{
    private IFlightService _flightService;

    public ServiceManager(IFlightService flightService)
    {
        _flightService = flightService;
    }

    public IFlightService FlightService => _flightService;
}
