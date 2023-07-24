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
using Airport.Service.TransportationOptionService;
using Airport.Service.TransportationProviderService;
using Airport.Service.TransportationUpdateService;
using AutoMapper;
using System.Security.Principal;

namespace Airport.Service
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
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
        public IFlightNotificationeRepositoy FlightNotification { get; set; }
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
        public ITransportationOptionRepository TransportationOption { get; set; }
        public ITransportationProviderRepository TransportationProvider { get; set; }
        public ITransportationUpdateRepository TransportationUpdate { get; set; }


        public UnitOfWorkRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            AirportInfo = new AirportInfoRepository(_context, _mapper);
            AccessibilityFeature = new AccessibilityFeatureRepository(_context, _mapper);
            AccessibilityOption = new AccessibilityOptionRepository(_context, _mapper);
            Aircraft = new AircraftRepository(_context, _mapper);
            Airline = new AirlineRepository(_context, _mapper);
            AirportAmenity = new AirportAmenityRepository(_context, _mapper);
            AirportLocation = new AirportLocationRepository(_context, _mapper);
            AirportContact = new AirportContactRepository(_context, _mapper);
            Baggage = new BaggageRepository(_context, _mapper);
            BoardingPass = new BoardingPassRepository(_context, _mapper);
            Booking = new BookingRepository(_context, _mapper);
            CheckInRequest = new CheckInRequestRepository(_context, _mapper);
            City = new CityRepository(_context, _mapper);
            Country = new CountryRepository(_context, _mapper);
            Flight = new FlightRepository(_context, _mapper);
            FlightNotification = new FlightNotificationeRepository(_context, _mapper);
            Language = new LanguageRepository(_context, _mapper);
            LoyaltyProgram = new LoyaltyProgramRepository(_context, _mapper);
            MapRoute = new MapRouteRepository(_context, _mapper);
            Passenger = new PassengerRepository(_context, _mapper);
            PassengerLocation = new PassengerLocationRepository();
            Payment = new PaymentRepository(_context, _mapper);
            PricingAndAvailability = new PricingAndAvailabilityRepository(_context, _mapper);
            SecurityCheckpoint = new SecurityCheckpointRepository(_context, _mapper);
            SecurityWaitTime = new SecurityWaitTimeRepositoy(_context, _mapper);
            Translation = new TranslationRepository(_context, _mapper);
            TransportationOption = new TransportationOptionRepository(_context, _mapper);
            TransportationProvider = new TransportationProviderRepository(_context, _mapper);
            TransportationUpdate = new TransportationUpdateRepository(_context, _mapper);
            _context = context;
        }
    }
}
