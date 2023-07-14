namespace Airport.Model
{
    public class Flight : BaseModel
    {
        public string FlightNumber { get; set; } = string.Empty;
        public DateTime ScheduledDepartureTime { get; set; }
        public DateTime ActualDepartureTime { get; set; }
        public string DepartureTerminal { get; set; } = string.Empty;
        public string DepartureGate { get; set; } = string.Empty;
        public DateTime ScheduledArrivalTime { get; set; }
        public DateTime ActualArrivalTime { get; set; }
        public string ArrivalTerminal { get; set; } = string.Empty;
        public string ArrivalGate { get; set; } = string.Empty;
        public string FlightStatus { get; set; } = string.Empty;


    }
}
