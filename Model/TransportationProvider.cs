﻿namespace Airport.Model
{
    public class TransportationProvider : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
