using Airport.Model;

namespace Airport.Service.CheckInRequestService
{
    public class CheckInRequestRepository : ICheckInRequestRepository
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

        public Task<List<CheckInRequest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CheckInRequest> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CheckInRequest> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CheckInRequest> Update(int id, CheckInRequest entity)
        {
            throw new NotImplementedException();
        }

        public Task<CheckInRequest> UpdateByEntity(CheckInRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}
