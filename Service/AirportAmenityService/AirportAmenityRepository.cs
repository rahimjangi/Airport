using Airport.Model;

namespace Airport.Service.AirportAmenityService
{
    public class AirportAmenityRepository : IAirportAmenityRepository
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

        public Task<List<ServiceResponse<AirportAmenity>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenity>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenity>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenity>> Update(int id, ServiceResponse<AirportAmenity> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenity>> UpdateByEntity(ServiceResponse<AirportAmenity> entity)
        {
            throw new NotImplementedException();
        }
    }
}
