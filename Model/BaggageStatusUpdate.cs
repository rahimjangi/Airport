namespace Airport.Model
{
    public class BaggageStatusUpdate : BaseModel
    {
        public string Status { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        // Additional properties as needed
    }

}
