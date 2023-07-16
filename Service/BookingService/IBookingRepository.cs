using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.BookingService
{
    public interface IBookingRepository : IEFRepository<Booking>
    {
    }
}
