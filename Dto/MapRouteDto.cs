namespace Airport.Dto;

public class MapRouteDto
{
    public int StartLocationId { get; set; }
    public int EndLocationId { get; set; }
    public string Description { get; set; } = string.Empty;
    public int DistanceInMeters { get; set; }
    // Additional properties as needed
}


