namespace Airport.Model
{
    public class BaggageStatusUpdate : BaseModel
    {
        public string BaggageStatus { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        // Additional properties as needed
    }

}
