using Airport.Model;

namespace Airport.Service.TransportationProviderService
{
    public class TransportationProviderRepository : ITransportationProviderRepository
    {
        public Task CreateByEntity(TransportationProvider entity)
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

        public Task<List<TransportationProvider>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TransportationProvider> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationProvider> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationProvider> Update(int id, TransportationProvider entity)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationProvider> UpdateByEntity(TransportationProvider entity)
        {
            throw new NotImplementedException();
        }
    }
}
