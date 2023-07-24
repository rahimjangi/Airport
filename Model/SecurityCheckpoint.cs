namespace Airport.Model
{
    public class SecurityCheckpoint : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int MaximumCapacity { get; set; }
        // Additional properties as needed
    }

    //public enum SecurityWaitTimeStatus
    //{
    //    Low,
    //    Moderate,
    //    High
    //}

}
