
namespace Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly IFlightRepository _flightRepository;
    private readonly IAirportRepository _airportRepository;

    public RepositoryManager(RepositoryContext context, IFlightRepository flightRepository, IAirportRepository airportRepository)
    {
        _context = context;
        _flightRepository = flightRepository;
        _airportRepository = airportRepository;
    }

    public IFlightRepository Flight => _flightRepository;

    public IAirportRepository Airport => _airportRepository;

    public void Save()
    {
        _context.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
