using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.BoardingPassService
{
    public interface IBoardingPassRepository : IEFRepository<BoardingPass>
    {
    }
}
