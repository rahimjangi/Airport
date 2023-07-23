using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.BoardingPassService
{
    public interface IBoardingPassRepository : IEFRepository<ServiceResponse<BoardingPassDto>>
    {
    }
}
