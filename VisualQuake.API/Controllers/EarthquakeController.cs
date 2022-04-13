namespace VisualQuake.API.Controllers;

[Route("api/earthquake")]
[ApiController]
public class EarthquakeController : ControllerBase
{
    private readonly IEarthquakeRepository _earthquakeRepository;

    public EarthquakeController(IEarthquakeRepository earthquakeRepository)
    {
        _earthquakeRepository = earthquakeRepository ?? throw new ArgumentNullException(nameof(earthquakeRepository));
    }

    [HttpGet("{count}")]
    public ActionResult<IEnumerable<Earthquake>> Get(int count)
    {
        IEnumerable<Earthquake> earthquakes = _earthquakeRepository.GetAll().OrderByDescending(e => e.Magnitude).Take(count);

        if (earthquakes is null) return NotFound();

        return Ok(earthquakes);
    }
}