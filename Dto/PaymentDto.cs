namespace Airport.Dto;

public class PaymentDto
{
    public int BookingId { get; set; }
    public int PassengerId { get; set; }
    public decimal PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
}
