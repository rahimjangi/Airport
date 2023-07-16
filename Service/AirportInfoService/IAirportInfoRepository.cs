using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AirportInfoService
{
    public interface IAirportInfoRepository : 
        IEFRepository<ServiceResponse<AirportInfo>>
    {
    }
}
