using Entities;

namespace Repositories;

public interface IFlightRepository : IRepositoryBase<Flight>
{
    IQueryable<Flight> GetAllFlights(bool trackChanges);
    Flight? GetOneFlight(int id, bool trackChanges);
    void CreateOneFlight(Flight flight);
    void DeleteOneFlight(Flight flight);
    void UpdateOneFlight(Flight entity);
}
