namespace Repositories;

public interface IRepositoryManager
{
    IFlightRepository Flight { get; }
    void Save();
    Task SaveAsync();
}
