namespace Airport.Model
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int AirlineId { get; set; }
        public int DepartureAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AircraftId { get; set; }
        // ...

        // Relationships
        public Airline Airline { get; set; }
        public Airport DepartureAirport { get; set; }
        public Airport DestinationAirport { get; set; }
        public Aircraft Aircraft { get; set; }
    }
}
