namespace Airport.Model
{
    public class Baggage : BaseModel
    {
        public string PassengerName { get; set; } = string.Empty;
        public string FlightNumber { get; set; } = string.Empty;
        public string BaggageTagNumber { get; set; } = string.Empty;
        public string BaggageStatus { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; } = string.Empty;
        public string TrackingNumber { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
