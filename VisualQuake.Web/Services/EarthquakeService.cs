namespace VisualQuake.Web.Services;

public class EarthquakeService : IEarthquakeService
{
    private readonly HttpClient httpClient;

    public EarthquakeService(HttpClient httpClient)
    {
        this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<IEnumerable<Earthquake>> GetEarthquakesAsync(int count)
    {
        HttpResponseMessage response = await httpClient.GetAsync($"api/earthquake/{count}");
        string result = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Earthquake>>(result);
    }
}
