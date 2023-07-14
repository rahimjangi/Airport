namespace Airport.Model;

public class AirportLocation : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    // Additional properties as needed
}


