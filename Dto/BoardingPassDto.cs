namespace Airport.Dto;

public class BoardingPassDto
{
    public string FlightNumber { get; set; } = string.Empty;
    public string PassengerName { get; set; } = string.Empty;
    public string SeatNumber { get; set; } = string.Empty;
    public DateTime CheckInTime { get; set; }
    public DateTime BoardingTime { get; set; }
    public string Gate { get; set; } = string.Empty;
    public bool IsCheckedIn { get; set; }
    public bool IsBoarded { get; set; }
    // Additional properties as needed
}

