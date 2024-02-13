namespace VisualQuake.Web.Services;

public interface IEarthquakeService
{
    Task<IEnumerable<Earthquake>> GetEarthquakesAsync(int count);
}