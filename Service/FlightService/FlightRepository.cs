using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.FlightService
{
    public class FlightRepository : IFlightRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FlightRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<FlightDto>>> GetAll()
        {
            var resultList = await _context.Flight.ToListAsync();
            var responseList = new List<ServiceResponse<FlightDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<FlightDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<FlightDto>
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
                var res = new ServiceResponse<FlightDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<FlightDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<Flight>(entity.Data);
                await _context.Flight.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }

        public async Task DeleteByName(string name)
        {
            var result = await _context.Flight.FirstOrDefaultAsync(n => n.FlightNumber.Equals(name));

            if (result != null)
            {
                _context.Flight.Remove(result);
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

        public Task<ServiceResponse<FlightDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FlightDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FlightDto>> Update(int id, ServiceResponse<FlightDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FlightDto>> UpdateByEntity(ServiceResponse<FlightDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
