namespace Airport.Model;

public class Aircraft : BaseModel
{
    public string Type { get; set; } = string.Empty;
    public int SeatingCapacity { get; set; }
}
