namespace VisualQuake.Infrastructure.Database.Repositories;

public class EarthquakeRepository : IEarthquakeRepository
{
    private readonly VisualQuakeContext _context;

    public EarthquakeRepository()
    {
        _context = new VisualQuakeContext();
    }

    public IEnumerable<Earthquake> GetAll() => _context.Earthquakes.ToList();
}