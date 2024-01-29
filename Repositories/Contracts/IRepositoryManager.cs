namespace Repositories;

public interface IRepositoryManager
{
    IFlightRepository Flight { get; }
    IAirportRepository Airport { get; }
    void Save();
    Task SaveAsync();
}
