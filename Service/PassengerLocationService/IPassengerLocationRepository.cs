using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.PassengerLocationService
{
    public interface IPassengerLocationRepository : IEFRepository<PassengerLocation>
    {
    }
}
