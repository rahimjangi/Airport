using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.FlightService
{
    public interface IFlightRepository : IEFRepository<ServiceResponse<FlightDto>>
    {
    }
}
