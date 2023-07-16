using Airport.Service.EFRepository;

namespace Airport.Service.AirportContactService
{
    public interface IAirportContactRepository : 
        IEFRepository<AirportContactRepository>
    {
    }
}
