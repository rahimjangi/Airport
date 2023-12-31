﻿namespace Airport.Model
{
    public class AirportAmenity : BaseModel
    {
        public int AirportServiceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string OpeningHours { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
