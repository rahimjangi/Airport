using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.TransportationProviderService
{
    public interface ITransportationProviderRepository : IEFRepository<TransportationProvider>
    {
    }
}
