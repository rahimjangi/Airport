using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.TransportationOptionService
{
    public interface ITransportationOptionRepository : IEFRepository<ServiceResponse<TransportationOptionDto>>
    {
    }
}
