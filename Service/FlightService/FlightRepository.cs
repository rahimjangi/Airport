using Airport.Model;

namespace Airport.Service.FlightService
{
    public class FlightRepository : IFlightRepository
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

        public Task<List<Flight>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Flight> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Flight> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Flight> Update(int id, Flight entity)
        {
            throw new NotImplementedException();
        }

        public Task<Flight> UpdateByEntity(Flight entity)
        {
            throw new NotImplementedException();
        }
    }
}
