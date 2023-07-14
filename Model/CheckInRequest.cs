namespace Airport.Model;

public class CheckInRequest : BaseModel
{
    public string FlightNumber { get; set; } = string.Empty;
    public string PassengerName { get; set; } = string.Empty;
    public string SeatNumber { get; set; } = string.Empty;
    // Additional check-in request properties as needed
}

