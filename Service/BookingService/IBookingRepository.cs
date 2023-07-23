using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.BookingService
{
    public interface IBookingRepository : IEFRepository<ServiceResponse<BookingDto>>
    {
    }
}
