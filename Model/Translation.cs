namespace Airport.Model
{
    public class Translation : BaseModel
    {
        public int LanguageId { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
