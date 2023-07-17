namespace Airport.Dto
{
    public class TranslationDto
    {
        public int LanguageId { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        // Additional properties as needed
    }

}
