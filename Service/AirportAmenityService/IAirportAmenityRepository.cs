using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AirportAmenityService
{
    public interface IAirportAmenityRepository : IEFRepository<ServiceResponse<AirportAmenityDto>>
    {
    }
}
