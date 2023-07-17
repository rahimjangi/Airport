namespace Airport.Dto
{
    public class TransportationUpdateDto
    {
        public int TransportationProviderId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Route { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string DisruptionDetails { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
