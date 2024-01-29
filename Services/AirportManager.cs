using System.Linq.Expressions;
using Entities;
using Repositories;

namespace Services;

public class AirportManager : IAirportService
{
    private readonly IRepositoryManager _manager;

    public AirportManager(IRepositoryManager manager)
    {
        _manager = manager;
    }

    public IEnumerable<Airport> GetAllAirports(bool trackChanges)
    {
        return _manager.Airport.GetAllAirports(trackChanges);
    }

    public Airport? GetOneAirport(int id, bool trackChanges)
    {
        var airport = _manager.Airport.GetOneAirport(id, trackChanges);

        if (airport is null)
            throw new Exception("Airport not found!");

        return airport;
    }

    public Airport? GetOneAirportByCondition(Expression<Func<Airport, bool>> expression, bool trackChanges)
    {
        return _manager.Airport.GetOneAirportByCondition(expression, false);
    }
}
