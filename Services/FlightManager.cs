using System.Linq.Expressions;
using AutoMapper;
using Entities;
using Repositories;

namespace Services;

public class FlightManager : IFlightService
{
    private readonly IRepositoryManager _manager;
    private readonly IMapper _mapper;

    public FlightManager(IRepositoryManager manager, IMapper mapper)
    {
        _manager = manager;
        _mapper = mapper;
    }

    public IEnumerable<Flight> GetAllFlights(bool trackChanges)
    {
        return _manager.Flight.GetAllFlights(trackChanges);
    }

    public Flight? GetOneFlight(int id, bool trackChanges)
    {
        var flight = _manager.Flight.GetOneFlight(id, trackChanges);

        if (flight is null)
            throw new Exception("Flight not found!");

        return flight;
    }

    public IQueryable<Flight> Where(Expression<Func<Flight, bool>> expression)
    {
        return _manager.Flight.Where(expression);
    }
}
