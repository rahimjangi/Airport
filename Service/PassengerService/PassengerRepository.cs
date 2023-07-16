using Airport.Model;

namespace Airport.Service.PassengerService
{
    public class PassengerRepository : IPassengerRepository
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

        public Task<List<Passenger>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> Update(int id, Passenger entity)
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> UpdateByEntity(Passenger entity)
        {
            throw new NotImplementedException();
        }
    }
}
