using Airport.Model;

namespace Airport.Dto;

public class CityDto
{
    public string Name { get; set; } = string.Empty;
    public CountryDto? Country { get; set; }
    // Additional properties as needed
}
