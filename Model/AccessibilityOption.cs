namespace Airport.Model
{
    public class AccessibilityOption : BaseModel
    {
        public int AccessibilityFeatureId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
