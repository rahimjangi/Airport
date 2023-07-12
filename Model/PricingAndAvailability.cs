namespace Airport.Model
{
    public class PricingAndAvailability
    {
        public int PricingId { get; set; }
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
