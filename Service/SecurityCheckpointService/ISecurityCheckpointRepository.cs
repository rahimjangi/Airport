using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.SecurityCheckpointService
{
    public interface ISecurityCheckpointRepository : IEFRepository<SecurityCheckpoint>
    {
    }
}
