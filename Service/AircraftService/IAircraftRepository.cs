using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AircraftService
{
    public interface IAircraftRepository : 
        IEFRepository<ServiceResponse<Aircraft>>
    {
    }
}
