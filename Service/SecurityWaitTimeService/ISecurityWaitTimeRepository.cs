using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.SecurityWaitTimeService
{
    public interface ISecurityWaitTimeRepository : IEFRepository<ServiceResponse<SecurityWaitTimeDto>>
    {
    }
}
