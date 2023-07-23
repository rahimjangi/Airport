using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.FlightNotificationeService
{
    public class FlightNotificationeRepository : IFlightNotificationeRepositoy
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FlightNotificationeRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<FlightNotificationeDto>>> GetAll()
        {
            var resultList = await _context.Country.ToListAsync();
            var responseList = new List<ServiceResponse<FlightNotificationeDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<FlightNotificationeDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<FlightNotificationeDto>
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
                var res = new ServiceResponse<FlightNotificationeDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<FlightNotificationeDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<FlightNotificatione>(entity.Data);
                await _context.FlightNotificatione.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.FlightNotificatione.FirstOrDefaultAsync(n => n.FlightNumber.Equals(name));

            if (result != null)
            {
                _context.FlightNotificatione.Remove(result);
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

        public Task<ServiceResponse<FlightNotificationeDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FlightNotificationeDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FlightNotificationeDto>> Update(int id, ServiceResponse<FlightNotificationeDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FlightNotificationeDto>> UpdateByEntity(ServiceResponse<FlightNotificationeDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
