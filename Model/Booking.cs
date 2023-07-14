namespace Airport.Model
{
    public class Booking : BaseModel
    {
        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public string BookingStatus { get; set; } = string.Empty;
    }
}
