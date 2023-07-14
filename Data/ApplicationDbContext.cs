using Airport.Model;
using Microsoft.EntityFrameworkCore;

namespace Airport.Data;



public class ApplicationDbContext : DbContext
{
    public DbSet<AirportInfo> AirportInfo { get; set; }
    public DbSet<Airline> Airlines { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Baggage> Baggages { get; set; } 
    public DbSet<Booking> Bookings { get; set; } 
    public DbSet<Passenger> Passengers { get; set; } = null!;
    public DbSet<Payment> payments { get; set; } = null!;
    public DbSet<PricingAndAvailability> pricingAndAvailabilities { get; set; } = null!;
    public DbSet<LoyaltyProgram> loyaltyPrograms { get; set; } = null!;
    public DbSet<Aircraft> Aircrafts { get; set; } = null!;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("air");
    }

}


