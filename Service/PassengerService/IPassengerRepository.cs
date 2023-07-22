using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.PassengerService
{
    public interface IPassengerRepository : IEFRepository<ServiceResponse<PassengerDto>>
    {
    }
}
