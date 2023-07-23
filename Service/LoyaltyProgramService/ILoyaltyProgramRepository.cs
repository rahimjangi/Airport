using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.LoyaltyProgramService
{
    public interface ILoyaltyProgramRepository : IEFRepository<ServiceResponse<LoyaltyProgramDto>>
    {
    }
}
