using System.Linq.Expressions;
using Entities;

namespace Services;

public interface IAirportService
{
    IEnumerable<Airport> GetAllAirports(bool trackChanges);
    Airport? GetOneAirport(int id, bool trackChanges);
    Airport? GetOneAirportByCondition(Expression<Func<Airport, bool>> expression, bool trackChanges);
}
