using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.CountryService
{
    public interface ICountryRepository : IEFRepository<Country>
    {
    }
}
