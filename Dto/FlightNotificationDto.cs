namespace Airport.Dto
{
    public class FlightNotificationeDto
        public string FlightNumber { get; set; } = string.Empty;
        public NotificationType Type { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public string RecipientUserId { get; set; } = string.Empty;
        public bool IsRead { get; set; }
    }

    public enum NotificationType
    {
        GateChange,
        Delay,
        Cancellation
    }
}
