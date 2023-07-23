using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.CityService
{
    public interface ICityRepository : IEFRepository<ServiceResponse<CityDto>>
    {
    }
}
