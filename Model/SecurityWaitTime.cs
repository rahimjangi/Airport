namespace Airport.Model
{
    public class SecurityWaitTime : BaseModel
    {
        public int SecurityCheckpointId { get; set; }
        public DateTime Timestamp { get; set; }
        public TimeSpan WaitTime { get; set; }
        public int NumberOfPeopleInQueue { get; set; }
        public int EstimatedWaitTime { get; set; }
        //public SecurityWaitTimeStatus SecurityStatus { get; set; }
        // Additional properties as needed
    }

}
