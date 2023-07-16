using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AirportLocationService
{
    public interface IAirportLocationRepository : 
        IEFRepository<ServiceResponse<AirportLocation>>
    {

    }
}
