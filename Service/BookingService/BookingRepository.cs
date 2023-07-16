using Airport.Model;

namespace Airport.Service.BookingService
{
    public class BookingRepository : IBookingRepository
    {
        public Task CreateByEntity(Booking entity)
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

        public Task<List<Booking>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> Update(int id, Booking entity)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> UpdateByEntity(Booking entity)
        {
            throw new NotImplementedException();
        }
    }
}
