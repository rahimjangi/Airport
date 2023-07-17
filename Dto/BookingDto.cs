namespace Airport.Dto
{
    public class BookingDto
    {
        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public string BookingStatus { get; set; } = string.Empty;
    }
}
