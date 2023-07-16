using Airport.Model;

namespace Airport.Service.AirportLocationService
{
    public class AirportLocationRepository : IAirportLocationRepository
    {
        public Task CreateByEntity(ServiceResponse<AirportLocation> entity)
        {
            throw new NotImplementedException();
        }

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

        public Task<List<ServiceResponse<AirportLocation>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocation>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocation>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocation>> Update(int id, ServiceResponse<AirportLocation> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocation>> UpdateByEntity(ServiceResponse<AirportLocation> entity)
        {
            throw new NotImplementedException();
        }
    }
}
