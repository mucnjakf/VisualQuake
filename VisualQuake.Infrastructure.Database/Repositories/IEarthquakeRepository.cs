namespace VisualQuake.Infrastructure.Database.Repositories;

public interface IEarthquakeRepository
{
    IEnumerable<Earthquake> GetAll();
}