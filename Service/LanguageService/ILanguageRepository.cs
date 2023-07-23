using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.LanguageService
{
    public interface ILanguageRepository : IEFRepository<ServiceResponse<LanguageDto>>
    {
    }
}
