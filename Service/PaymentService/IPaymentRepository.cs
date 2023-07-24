using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.PaymentService
{
    public interface IPaymentRepository : IEFRepository<ServiceResponse<PaymentDto>>
    {
    }
}
