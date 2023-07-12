namespace Airport.Model;

public class LoyaltyProgram
{
    public int LoyaltyId { get; set; }
    public int PassengerId { get; set; }
    public int LoyaltyPoints { get; set; }
    // ...

    // Relationships
    public Passenger Passenger { get; set; }
}
