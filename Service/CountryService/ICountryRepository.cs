using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.CountryService
{
    public interface ICountryRepository : IEFRepository<ServiceResponse<CountryDto>>
    {
    }
}
