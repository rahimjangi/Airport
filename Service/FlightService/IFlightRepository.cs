using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.FlightService
{
    public interface IFlightRepository : IEFRepository<Flight>
    {
    }
}
