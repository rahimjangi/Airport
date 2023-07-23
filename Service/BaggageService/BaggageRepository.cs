using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.BaggageService
{
    public class BaggageRepository : IBaggageRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BaggageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<BaggageDto>>> GetAll()
        {
            var resultList = await _context.Baggages.ToListAsync();
            var responseList = new List<ServiceResponse<BaggageDto>>();

            if (resultList != null && resultList.Count > 0)
            {
                var mapResult = _mapper.Map<List<BaggageDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<BaggageDto>
                    {
                        Data = result,
                        Message = "Result found",
                        Success = true
                    };

                    responseList.Add(res);
                }
            }
            else
            {
                var res = new ServiceResponse<BaggageDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = true
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<BaggageDto> entity)
        {
            if (entity.Data != null)
            {
                var mapresult = _mapper.Map<Baggage>(entity.Data);
                await _context.Baggages.AddAsync(mapresult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }
        public async Task DeleteByName(string tagNumber)
        {
            var result = await _context.Baggages.FirstOrDefaultAsync(n => n.BaggageTagNumber.Equals(tagNumber));

            if (result != null)
            {
                _context.Baggages.Remove(result);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }       

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }      

        public Task<ServiceResponse<BaggageDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BaggageDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BaggageDto>> Update(int id, ServiceResponse<BaggageDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BaggageDto>> UpdateByEntity(ServiceResponse<BaggageDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
