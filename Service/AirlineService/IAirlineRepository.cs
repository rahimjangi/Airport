using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AirlineService
{
    public interface IAirlineRepository :
        IEFRepository<ServiceResponse<AirlineDto>>
    {
    }
}
