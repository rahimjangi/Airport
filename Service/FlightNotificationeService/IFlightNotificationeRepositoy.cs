using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.FlightNotificationeService
{
    public interface IFlightNotificationeRepositoy : IEFRepository<ServiceResponse<FlightNotificationeDto>>
    {
    }
}
