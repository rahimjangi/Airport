using Airport.Model;

namespace Airport.Service.PaymentService
{
    public class PaymentRepository : IPaymentRepository
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

        public Task<List<Payment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Payment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> Update(int id, Payment entity)
        {
            throw new NotImplementedException();
        }

        public Task<Payment> UpdateByEntity(Payment entity)
        {
            throw new NotImplementedException();
        }
    }
}
