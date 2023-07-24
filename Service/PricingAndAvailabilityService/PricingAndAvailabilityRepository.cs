using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.PricingAndAvailabilityService
{
    public class PricingAndAvailabilityRepository : IPricingAndAvailabilityRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PricingAndAvailabilityRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<List<ServiceResponse<PricingAndAvailabilityDto>>> GetAll()
        {
            var resultList = await _context.PricingAndAvailability.ToListAsync();
            var responseList = new List<ServiceResponse<PricingAndAvailabilityDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<PricingAndAvailabilityDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<PricingAndAvailabilityDto>
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
                var res = new ServiceResponse<PricingAndAvailabilityDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<PricingAndAvailabilityDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<PricingAndAvailability>(entity.Data);
                await _context.PricingAndAvailability.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.PricingAndAvailability.FirstOrDefaultAsync(n => n.FlightId.Equals(id));

            if (result != null)
            {
                _context.PricingAndAvailability.Remove(result);
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

        public Task<ServiceResponse<PricingAndAvailabilityDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PricingAndAvailabilityDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PricingAndAvailabilityDto>> Update(int id, ServiceResponse<PricingAndAvailabilityDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PricingAndAvailabilityDto>> UpdateByEntity(ServiceResponse<PricingAndAvailabilityDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
