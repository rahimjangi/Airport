using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.PaymentService
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PaymentRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<PaymentDto>>> GetAll()
        {
            var resultList = await _context.Payment.ToListAsync();
            var responseList = new List<ServiceResponse<PaymentDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<PaymentDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<PaymentDto>
                    {
                        Data = result,
                        Message = "Result found",
                        Success = true,
                    };

                    responseList.Add(res);
                }
            }
            else
            {
                var res = new ServiceResponse<PaymentDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }

        public async Task CreateByEntity(ServiceResponse<PaymentDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<Payment>(entity.Data);
                await _context.Payment.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.Payment.FirstOrDefaultAsync(n => n.BookingId.Equals(id));

            if (result != null)
            {
                _context.Payment.Remove(result);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public Task DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }        

        public Task<ServiceResponse<PaymentDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PaymentDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PaymentDto>> Update(int id, ServiceResponse<PaymentDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PaymentDto>> UpdateByEntity(ServiceResponse<PaymentDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
