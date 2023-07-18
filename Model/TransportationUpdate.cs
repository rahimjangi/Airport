namespace Airport.Model
{
    public class TransportationUpdate : BaseModel
    {
        public int TransportationProviderId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Route { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public string TransportationUpdateStatus { get; set; } = string.Empty;
        public string DisruptionDetails { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
