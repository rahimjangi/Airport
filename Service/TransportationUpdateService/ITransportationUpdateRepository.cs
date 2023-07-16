using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.TransportationUpdateService
{
    public interface ITransportationUpdateRepository : IEFRepository<TransportationUpdate>
    {
    }
}
