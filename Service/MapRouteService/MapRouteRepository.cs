using Airport.Model;

namespace Airport.Service.MapRouteService
{
    public class MapRouteRepository : IMapRouteRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }

        public Task<List<MapRoute>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<MapRoute> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MapRoute> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<MapRoute> Update(int id, MapRoute entity)
        {
            throw new NotImplementedException();
        }

        public Task<MapRoute> UpdateByEntity(MapRoute entity)
        {
            throw new NotImplementedException();
        }
    }
}
