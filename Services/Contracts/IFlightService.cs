using System.Linq.Expressions;
using Entities;

namespace Services;

public interface IFlightService
{
    IEnumerable<Flight> GetAllFlights(bool trackChanges);
    Flight? GetOneFlight(int id, bool trackChanges);
    IEnumerable<Flight>? GetAllFlightsByCondition(Expression<Func<Flight, bool>> expression, bool trackChanges);
}
