using Airport.Model;

namespace Airport.Service.AirportInfoService
{
    public class AirportInfoRepository : IAirportInfoRepository
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

        public Task<List<ServiceResponse<AirportInfo>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportInfo>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportInfo>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportInfo>> Update(int id, ServiceResponse<AirportInfo> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportInfo>> UpdateByEntity(ServiceResponse<AirportInfo> entity)
        {
            throw new NotImplementedException();
        }
    }
}
