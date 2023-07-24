using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.PassengerLocationService
{
    public interface IPassengerLocationRepository : IEFRepository<ServiceResponse<PassengerLocationDto>>
    {
    }
}
