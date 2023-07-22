using Airport.Service.EFRepository;
using Airport.Dto;

namespace Airport.Service.AirportContactService
{
    public interface IAirportContactRepository : IEFRepository<ServiceResponse<AirportContactDto>>
    {
    }
}
