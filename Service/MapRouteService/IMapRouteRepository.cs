using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.MapRouteService
{
    public interface IMapRouteRepository : IEFRepository<ServiceResponse<MapRouteDto>>
    {
    }
}
