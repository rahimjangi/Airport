using Airport.Model;

namespace Airport.Service.CountryService
{
    public class CountryRepository : ICountryRepository
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

        public Task<List<Country>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Country> Update(int id, Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<Country> UpdateByEntity(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
