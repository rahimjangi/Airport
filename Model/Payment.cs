namespace Airport.Model;

public class Payment
{
    public int PaymentId { get; set; }
    public int BookingId { get; set; }
    public int PassengerId { get; set; }
    public decimal PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
    // ...

    // Relationships
    public Booking Booking { get; set; }
    public Passenger Passenger { get; set; }
}
