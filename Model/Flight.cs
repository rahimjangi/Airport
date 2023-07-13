namespace Airport.Model
{
    public class Flight : BaseModel
    {
        public int AirlineId { get; set; }
        public int DepartureAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AircraftId { get; set; }

        
    }
}
