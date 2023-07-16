using Airport.Model;

namespace Airport.Service.SecurityCheckpointService
{
    public class SecurityCheckpointRepository : ISecurityCheckpointRepository
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

        public Task<List<SecurityCheckpoint>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SecurityCheckpoint> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SecurityCheckpoint> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<SecurityCheckpoint> Update(int id, SecurityCheckpoint entity)
        {
            throw new NotImplementedException();
        }

        public Task<SecurityCheckpoint> UpdateByEntity(SecurityCheckpoint entity)
        {
            throw new NotImplementedException();
        }
    }
}
