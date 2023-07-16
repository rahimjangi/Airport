using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.SecurityWaitTimeService
{
    public interface ISecurityWaitTimeRepository : IEFRepository<SecurityWaitTime>
    {
    }
}
