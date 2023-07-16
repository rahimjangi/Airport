using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.BaggageService
{
    public interface IBaggageRepository : 
        IEFRepository<Baggage>
    {
    }
}
