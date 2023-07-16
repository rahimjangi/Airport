using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.TransportationOptionService
{
    public interface ITransportationOptionRepository : IEFRepository<TransportationOption>
    {
    }
}
