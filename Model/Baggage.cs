namespace Airport.Model
{
    public class Baggage
    {
        public int BaggageId { get; set; }
        public int BookingId { get; set; }
        public int PassengerId { get; set; }
        public decimal Weight { get; set; }
        // ...

        // Relationships
        public Booking Booking { get; set; }
        public Passenger Passenger { get; set; }
    }
}
