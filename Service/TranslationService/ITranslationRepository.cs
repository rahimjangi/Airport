using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.TranslationService
{
    public interface ITranslationRepository : IEFRepository<Translation>
    {
    }
}
