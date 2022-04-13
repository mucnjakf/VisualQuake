using System.Text.Json.Serialization;

namespace VisualQuake.Shared.Models;

public class Earthquake
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("magnitude")]
    public double Magnitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    public string Description { get => $"M{Magnitude} - {Location}"; }

    public override string ToString()
    {
        return
            $"Location: {Location}\n" +
            $"Magnitude: {Magnitude}\n" +
            $"Coordinates: {Longitude} - {Latitude}";
    }
}
