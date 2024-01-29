using System.Linq.Expressions;
using Entities;

namespace Repositories;

public interface IFlightRepository : IRepositoryBase<Flight>
{
    IQueryable<Flight> GetAllFlights(bool trackChanges);
    Flight? GetOneFlight(int id, bool trackChanges);
    public IEnumerable<Flight>? GetAllFlightsByCondition(Expression<Func<Flight, bool>> expression, bool trackChanges);
    void CreateOneFlight(Flight flight);
    void DeleteOneFlight(Flight flight);
    void UpdateOneFlight(Flight entity);
}
