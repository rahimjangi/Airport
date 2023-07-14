using System.ComponentModel.DataAnnotations;

namespace Airport.Model;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime ArchiveDate { get; set; }
    public Status Status { get; set; }
}

public enum Status
{
    Insert = 1,
    Update = 2,
    Delete = 3
}
