
namespace Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly IFlightRepository _flightRepository;

    public RepositoryManager(RepositoryContext context, IFlightRepository flightRepository)
    {
        _context = context;
        _flightRepository = flightRepository;
    }

    public IFlightRepository Flight => _flightRepository;

    public void Save()
    {
        _context.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
