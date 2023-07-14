namespace Airport.Model;

public class MapRoute : BaseModel
{
    public int StartLocationId { get; set; }
    public int EndLocationId { get; set; }
    public string Description { get; set; } = string.Empty;
    public int DistanceInMeters { get; set; }
    // Additional properties as needed
}


