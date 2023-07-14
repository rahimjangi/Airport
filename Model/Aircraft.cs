namespace Airport.Model;

public class Aircraft : BaseModel
{
    public string AircraftCode { get; set; } = string.Empty;
    public string AircraftModel { get; set; } = string.Empty;
    public int TotalSeats { get; set; }
    public DateTime ManufacturingDate { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public Country? CountryOfOrigin { get; set; }
    public City? CurrentLocation { get; set; }
}
