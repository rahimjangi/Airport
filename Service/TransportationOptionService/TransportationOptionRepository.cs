using Airport.Model;

namespace Airport.Service.TransportationOptionService
{
    public class TransportationOptionRepository : ITransportationOptionRepository
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

        public Task<List<TransportationOption>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TransportationOption> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationOption> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationOption> Update(int id, TransportationOption entity)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationOption> UpdateByEntity(TransportationOption entity)
        {
            throw new NotImplementedException();
        }
    }
}
