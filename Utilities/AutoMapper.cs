using Airport.Dto;
using Airport.Model;
using AutoMapper;

namespace Airport.Utilities
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AccessibilityFeature, AccessibilityFeatureDto>().ReverseMap();
            CreateMap<AccessibilityOption, AccessibilityOptionDto>().ReverseMap();
            CreateMap<Aircraft, AircraftDto>().ReverseMap();
            CreateMap<Airline, AirlineDto>().ReverseMap();
            CreateMap<AirportAmenity, AirportAmenityDto>().ReverseMap();
            CreateMap<AirportContact, AirportContactDto>().ReverseMap();
            CreateMap<AirportInfo, AirportInfoDto>().ReverseMap();
            CreateMap<AirportLocation, AirportLocationDto>().ReverseMap();
            CreateMap<Baggage, BaggageDto>().ReverseMap();
            CreateMap<BaggageStatusUpdate, BaggageStatusUpdateDto>().ReverseMap();
            CreateMap<BoardingPass, BoardingPassDto>().ReverseMap();
            CreateMap<Booking, BookingDto>().ReverseMap();
            CreateMap<CheckInRequest, CheckInRequestDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Flight, FlightDto>().ReverseMap();
            CreateMap<FlightNotificatione, FlightNotificationeDto>().ReverseMap();
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<LoyaltyProgram, LoyaltyProgramDto>().ReverseMap();
            CreateMap<MapRoute, MapRouteDto>().ReverseMap();
            CreateMap<Passenger, PassengerDto>().ReverseMap();
            CreateMap<PassengerLocation, PassengerLocationDto>().ReverseMap();
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<PricingAndAvailability, PricingAndAvailabilityDto>().ReverseMap();
            CreateMap<SecurityCheckpoint, SecurityCheckpointDto>().ReverseMap();
            CreateMap<SecurityWaitTime, SecurityWaitTimeDto>().ReverseMap();
            CreateMap<Translation, TranslationDto>().ReverseMap();
            CreateMap<TransportationOption, TransportationOptionDto>().ReverseMap();
            CreateMap<TransportationProvider, TransportationProviderDto>().ReverseMap();
            CreateMap<TransportationUpdate, TransportationUpdateDto>().ReverseMap();
        }
    }
}
