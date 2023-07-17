namespace Airport.Dto
{
    public class SecurityWaitTimeDto
    {
        public int SecurityCheckpointId { get; set; }
        public DateTime Timestamp { get; set; }
        public TimeSpan WaitTime { get; set; }
        public int NumberOfPeopleInQueue { get; set; }
        public int EstimatedWaitTime { get; set; }
        public SecurityWaitTimeStatus Status { get; set; }
        // Additional properties as needed
    }

}
