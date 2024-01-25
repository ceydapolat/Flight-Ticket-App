using System.Linq.Expressions;
using Entities;

namespace Services;

public interface IFlightService
{
    IEnumerable<Flight> GetAllFlights(bool trackChanges);
    Flight? GetOneFlight(int id, bool trackChanges);
    IQueryable<Flight> Where(Expression<Func<Flight, bool>> expression);
}
