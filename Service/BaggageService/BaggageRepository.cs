using Airport.Model;

namespace Airport.Service.BaggageService
{
    public class BaggageRepository : IBaggageRepository
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

        public Task<List<Baggage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Baggage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Baggage> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Baggage> Update(int id, Baggage entity)
        {
            throw new NotImplementedException();
        }

        public Task<Baggage> UpdateByEntity(Baggage entity)
        {
            throw new NotImplementedException();
        }
    }
}
