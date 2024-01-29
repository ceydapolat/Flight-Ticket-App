using System.Linq.Expressions;
using Entities;

namespace Repositories;

public class FlightRepository : RepositoryBase<Flight>, IFlightRepository
{
    public FlightRepository(RepositoryContext context) : base(context)
    {
    }

    public void CreateOneFlight(Flight flight) => Create(flight);

    public void DeleteOneFlight(Flight flight) => Remove(flight);

    public IQueryable<Flight> GetAllFlights(bool trackChanges) => FindAll(trackChanges);

    public Flight? GetOneFlight(int id, bool trackChanges)
    {
        return FindByCondition(p => p.FlightId.Equals(id), trackChanges);
    }

    public void UpdateOneFlight(Flight flight) => Update(flight);

    public IEnumerable<Flight>? GetAllFlightsByCondition(Expression<Func<Flight, bool>> expression, bool trackChanges)
    {
        return FindAllByCondition(expression, trackChanges);
    }
}
