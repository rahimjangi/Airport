using Airport.Model;

namespace Airport.Service.CityService
{
    public class CityRepository : ICityRepository
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

        public Task<List<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<City> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<City> Update(int id, City entity)
        {
            throw new NotImplementedException();
        }

        public Task<City> UpdateByEntity(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
