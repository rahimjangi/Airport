using Airport.Model;

namespace Airport.Service.TransportationUpdateService
{
    public class TransportationUpdateRepository : ITransportationUpdateRepository
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

        public Task<List<TransportationUpdate>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TransportationUpdate> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationUpdate> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationUpdate> Update(int id, TransportationUpdate entity)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationUpdate> UpdateByEntity(TransportationUpdate entity)
        {
            throw new NotImplementedException();
        }
    }
}
