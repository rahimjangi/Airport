namespace Airport.Model
{
    public class Baggage : BaseModel
    {
        public int BookingId { get; set; }
        public int PassengerId { get; set; }
        public decimal Weight { get; set; }
       
    }
}
