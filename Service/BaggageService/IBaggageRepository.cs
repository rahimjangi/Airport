using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.BaggageService
{
    public interface IBaggageRepository : 
        IEFRepository<ServiceResponse<BaggageDto>>
    {
    }
}
