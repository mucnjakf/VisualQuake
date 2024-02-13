namespace VisualQuake.API;

public class DependencyRegistration
{
    public static void Register(IServiceCollection services)
    {
        services.AddSingleton<IEarthquakeRepository, EarthquakeRepository>();
    }
}

