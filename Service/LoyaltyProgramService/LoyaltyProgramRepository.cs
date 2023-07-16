using Airport.Model;

namespace Airport.Service.LoyaltyProgramService
{
    public class LoyaltyProgramRepository : ILoyaltyProgramRepository
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

        public Task<List<LoyaltyProgram>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LoyaltyProgram> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LoyaltyProgram> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<LoyaltyProgram> Update(int id, LoyaltyProgram entity)
        {
            throw new NotImplementedException();
        }

        public Task<LoyaltyProgram> UpdateByEntity(LoyaltyProgram entity)
        {
            throw new NotImplementedException();
        }
    }
}
