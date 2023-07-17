using Airport.Model;

namespace Airport.Service.AircraftService
{
    public class AircraftRepository : IAircraftRepository
    {
        public Task CreateByEntity(ServiceResponse<Aircraf> entity)
        {
            throw new NotImplementedException();
        }

        public  Task DeleteById(int id)
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

        public Task<List<ServiceResponse<Aircraft>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Aircraft>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Aircraft>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Aircraft>> Update(int id, ServiceResponse<Aircraft> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Aircraft>> UpdateByEntity(ServiceResponse<Aircraft> entity)
        {
            throw new NotImplementedException();
        }
    }
}
