namespace Airport.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public string SeatNumber { get; set; }
        public string BookingStatus { get; set; }
        // ...

        // Relationships
        public Passenger Passenger { get; set; }
        public Flight Flight { get; set; }
    }
}
