namespace Airport.Dto
{
    public class PricingAndAvailabilityDto
    {
        public int FlightId { get; set; }
        public DateTime Date { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
