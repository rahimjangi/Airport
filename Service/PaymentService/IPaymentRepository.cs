using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.PaymentService
{
    public interface IPaymentRepository : IEFRepository<Payment>
    {
    }
}
