using Airport.Model;

namespace Airport.Service.TranslationService
{
    public class TranslationRepository : ITranslationRepository
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

        public Task<List<Translation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Translation> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Translation> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Translation> Update(int id, Translation entity)
        {
            throw new NotImplementedException();
        }

        public Task<Translation> UpdateByEntity(Translation entity)
        {
            throw new NotImplementedException();
        }
    }
}
