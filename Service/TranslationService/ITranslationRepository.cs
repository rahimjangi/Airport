using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.TranslationService
{
    public interface ITranslationRepository : IEFRepository<ServiceResponse<TranslationDto>>
    {
    }
}
