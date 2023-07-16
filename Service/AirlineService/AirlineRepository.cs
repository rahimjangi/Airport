using Airport.Model;

namespace Airport.Service.AirlineService
{
    public class AirlineRepository : IAirlineRepository
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

        public Task<List<ServiceResponse<Airline>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Airline>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Airline>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Airline>> Update(int id, ServiceResponse<Airline> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Airline>> UpdateByEntity(ServiceResponse<Airline> entity)
        {
            throw new NotImplementedException();
        }
    }
}
