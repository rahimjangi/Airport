using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.AirportLocationService
{
    public interface IAirportLocationRepository : 
        IEFRepository<ServiceResponse<AirportLocationDto>>
    {

    }
}
