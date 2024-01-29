using System.Linq.Expressions;
using Entities;

namespace Repositories;

public class AirportRepository : RepositoryBase<Airport>, IAirportRepository
{
    public AirportRepository(RepositoryContext context) : base(context)
    {
    }

    public IQueryable<Airport> GetAllAirports(bool trackChanges) => FindAll(trackChanges);

    public Airport? GetOneAirport(int id, bool trackChanges)
    {
        return FindByCondition(p => p.AirportId.Equals(id), trackChanges);
    }

    public Airport? GetOneAirportByCondition(Expression<Func<Airport, bool>> expression, bool trackChanges)
    {
        return FindByCondition(expression, trackChanges);
    }
}
