using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.SecurityCheckpointService
{
    public interface ISecurityCheckpointRepository : IEFRepository<ServiceResponse<SecurityCheckpointDto>>
    {
    }
}
