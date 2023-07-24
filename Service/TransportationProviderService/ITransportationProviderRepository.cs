using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.TransportationProviderService
{
    public interface ITransportationProviderRepository : IEFRepository<ServiceResponse<TransportationProviderDto>>
    {
    }
}
