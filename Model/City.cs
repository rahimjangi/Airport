namespace Airport.Model;

public class City : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public Country? Country { get; set; }
    // Additional properties as needed
}
