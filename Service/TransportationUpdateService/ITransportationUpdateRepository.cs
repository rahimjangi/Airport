using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.TransportationUpdateService
{
    public interface ITransportationUpdateRepository : IEFRepository<ServiceResponse<TransportationUpdateDto>>
    {
    }
}
