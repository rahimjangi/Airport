namespace Airport.Model
{
    public class PricingAndAvailability : BaseModel
    {
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
