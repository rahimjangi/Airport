using Airport.Model;

namespace Airport.Service.BoardingPassService
{
    public class BoardingPassRepository : IBoardingPassRepository
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

        public Task<List<BoardingPass>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BoardingPass> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BoardingPass> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<BoardingPass> Update(int id, BoardingPass entity)
        {
            throw new NotImplementedException();
        }

        public Task<BoardingPass> UpdateByEntity(BoardingPass entity)
        {
            throw new NotImplementedException();
        }
    }
}
