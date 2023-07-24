using Airport.Dto;

namespace Airport.Service.PassengerLocationService
{
    public class PassengerLocationRepository : IPassengerLocationRepository
    {
        public Task CreateByEntity(ServiceResponse<PassengerLocationDto> entity)
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

        public Task<List<ServiceResponse<PassengerLocationDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerLocationDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerLocationDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerLocationDto>> Update(int id, ServiceResponse<PassengerLocationDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerLocationDto>> UpdateByEntity(ServiceResponse<PassengerLocationDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
