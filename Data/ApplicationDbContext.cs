using Airport.Model;
using Microsoft.EntityFrameworkCore;

namespace Airport.Data;



public class ApplicationDbContext : DbContext
{
    public DbSet<AccessibilityFeature> AccessibilityFeature { get; set; } = null!;
    public DbSet<AccessibilityOption> AccessibilityOption { get; set; } = null!;
    public DbSet<Aircraft> Aircrafts { get; set; } = null!;
    public DbSet<Airline> Airlines { get; set; }
    public DbSet<AirportAmenity> AirportAmenity { get; set; } = null!;
    public DbSet<AirportContact> AirportContact { get; set; } = null!;
    public DbSet<AirportInfo> AirportInfo { get; set; }
    public DbSet<AirportLocation> AirportLocation { get; set; } = null!;
    public DbSet<Baggage> Baggages { get; set; }
    public DbSet<BaggageStatusUpdate> BaggageStatusUpdate { get; set; } = null!;
    public DbSet<BoardingPass> BoardingPass { get; set; } = null!;
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<CheckInRequest> CheckInRequest { get; set; } = null!;
    public DbSet<City> City { get; set; } = null!;
    public DbSet<Country> Country { get; set; } = null!;
    public DbSet<Flight> Flight { get; set; } = null!;
    public DbSet<FlightNotificatione> FlightNotificatione { get; set; } = null!;
    public DbSet<Language> Language { get; set; } = null!;
    public DbSet<LoyaltyProgram> LoyaltyPrograms { get; set; } = null!;
    public DbSet<MapRoute> MapRoute { get; set; } = null!;
    public DbSet<Passenger> Passenger { get; set; } = null!;
    public DbSet<PassengerLocation> PassengerLocation { get; set; } = null!;   
    public DbSet<Payment> Payment { get; set; } = null!;
    public DbSet<PricingAndAvailability> PricingAndAvailability { get; set; } = null!;
    public DbSet<SecurityCheckpoint> SecurityCheckpoint { get; set; } = null!;
    public DbSet<SecurityWaitTime> SecurityWaitTime { get; set; } = null!;
    public DbSet<Translation> Translation { get; set; } = null!;
    public DbSet<TransportationOption> TransportationOption { get; set; } = null!;
    public DbSet<TransportationProvider> TransportationProvider { get; set; } = null!;
    public DbSet<TransportationUpdate> TransportationUpdate { get; set; } = null!;



    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("air");
    }

}


