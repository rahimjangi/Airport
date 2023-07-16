using Airport.Data;
using Airport.Model;
using Airport.Service.AccessibilityFeatureService;
using Airport.Service.AccessibilityOptionService;
using Airport.Service.AircraftService;
using Airport.Service.AirlineService;
using Airport.Service.AirportAmenityService;
using Airport.Service.AirportContactService;
using Airport.Service.AirportInfoService;
using Airport.Service.AirportLocationService;
using Airport.Service.BaggageService;
using Airport.Service.BoardingPassService;
using Airport.Service.BookingService;
using Airport.Service.CheckInRequestService;
using Airport.Service.CityService;
using Airport.Service.CountryService;
using Airport.Service.FlightNotificationeService;
using Airport.Service.FlightService;
using Airport.Service.LanguageService;
using Airport.Service.LoyaltyProgramService;
using Airport.Service.MapRouteService;
using Airport.Service.PassengerLocationService;
using Airport.Service.PassengerService;
using Airport.Service.PaymentService;
using Airport.Service.PricingAndAvailabilityService;
using Airport.Service.SecurityCheckpointService;
using Airport.Service.SecurityWaitTimeService;
using Airport.Service.TranslationService;
using Airport.Service.TransportationProviderService;
using Airport.Service.TransportationUpdateService;
using System.Security.Principal;

namespace Airport.Service
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly ApplicationDbContext _context;
        public IAirlineRepository Airline { get; set; }
        public IAirportInfoRepository AirportInfo { get; set; }
        public IAccessibilityFeatureRepository AccessibilityFeature { get; set; }
        public IAccessibilityOptionRepository AccessibilityOption { get; set; }
        public IAircraftRepository Aircraft { get; set; }
        public IAirportAmenityRepository AirportAmenity { get; set; }
        public IAirportLocationRepository AirportLocation { get; set; }
        public IAirportContactRepository AirportContact { get; set; }
        public IBaggageRepository Baggage { get; set; }
        public IBoardingPassRepository BoardingPass { get; set; }
        public IBookingRepository Booking { get; set; }
        public ICheckInRequestRepository CheckInRequest { get; set; }
        public ICityRepository City { get; set; }
        public ICountryRepository Country { get; set; }
        public IFlightRepository Flight { get; set; }
        public IFlightNotificationeRepositoy FlightNotificatione { get; set; }
        public ILanguageRepository Language { get; set; }
        public ILoyaltyProgramRepository LoyaltyProgram { get; set; }
        public IMapRouteRepository MapRoute { get; set; }
        public IPassengerRepository Passenger { get; set; }
        public IPassengerLocationRepository PassengerLocation { get; set; }
        public IPaymentRepository Payment { get; set; }
        public IPricingAndAvailabilityRepository PricingAndAvailability { get; set; }
        public ISecurityCheckpointRepository SecurityCheckpoint { get; set; }
        public ISecurityWaitTimeRepository SecurityWaitTime { get; set; }
        public ITranslationRepository Translation { get; set; }
        public ITransportationProviderRepository TransportationProvider { get; set; }
        public ITransportationUpdateRepository TransportationUpdate { get; set; }


        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            _context=context;
            AirportInfo = new AirportInfoRepository();
            AccessibilityFeature = new AccessibilityFeatureRepository();
            AccessibilityOption = new AccessibilityOptionRepository();
            Aircraft = new AircraftRepository();
            Airline = new AirlineRepository(_context);
            AirportAmenity = new AirportAmenityRepository();
            AirportLocation = new AirportLocationRepository();
            AirportContact = new AirportContactRepository();
            Baggage = new BaggageRepository();
            BoardingPass = new BoardingPassRepository();
            Booking = new BookingRepository();
            CheckInRequest = new CheckInRequestRepository();
            City = new CityRepository();
            Country = new CountryRepository();
            Flight = new FlightRepository();
            FlightNotificatione = new FlightNotificationeRepository();
            Language = new LanguageRepository();
            LoyaltyProgram = new LoyaltyProgramRepository();
            MapRoute = new MapRouteRepository();
            Passenger = new PassengerRepository();
            PassengerLocation = new PassengerLocationRepository();
            Payment = new PaymentRepository();
            PricingAndAvailability = new PricingAndAvailabilityRepository();
            SecurityCheckpoint = new SecurityCheckpointRepository();
            SecurityWaitTime = new SecurityWaitTimeRepositoy();
            Translation = new TranslationRepository();
            TransportationProvider = new TransportationProviderRepository();
            TransportationUpdate = new TransportationUpdateRepository();
            _context = context;
        }
    }
}
