using System.Linq.Expressions;
using Entities;

namespace Repositories;

public interface IAirportRepository : IRepositoryBase<Airport>
{
    IQueryable<Airport> GetAllAirports(bool trackChanges);
    Airport? GetOneAirport(int id, bool trackChanges);
    Airport? GetOneAirportByCondition(Expression<Func<Airport, bool>> expression, bool trackChanges);
}
