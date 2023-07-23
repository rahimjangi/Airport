using Airport.Dto;
using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.CheckInRequestService
{
    public interface ICheckInRequestRepository :
        IEFRepository<ServiceResponse<CheckInRequestDto>>
    {
    }
}
