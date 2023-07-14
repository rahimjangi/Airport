namespace Airport.Model;

public class Passenger : BaseModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PassportNumber { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string SeatNumber { get; set; } = string.Empty;
    public string FlightNumber { get; set; } = string.Empty;
    public double CurrentLatitude { get; set; }
    public double CurrentLongitude { get; set; }
}
