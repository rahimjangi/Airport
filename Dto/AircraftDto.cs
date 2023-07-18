namespace Airport.Dto;

public class AircraftDto
{
    public string AircraftCode { get; set; } = string.Empty;
    public string AircraftModel { get; set; } = string.Empty;
    public int TotalSeats { get; set; }
    public DateTime ManufacturingDate { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public CountryDto? CountryOfOrigin { get; set; }
    public CityDto? CurrentLocation { get; set; }
}
