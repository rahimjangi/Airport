using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.PassengerService
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PassengerRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<PassengerDto>>> GetAll()
        {
            var resultList = await _context.Passenger.ToListAsync();

            var responseList = new List<ServiceResponse<PassengerDto>>();

            if(resultList != null && resultList.Count > 0)
            {
                var mapResult = _mapper.Map<List<PassengerDto>>(resultList);

                foreach( var result in mapResult)
                {
                    var res = new ServiceResponse<PassengerDto>
                    {
                        Data = result,
                        Message = "Result Founded",
                        Success = true
                    };
                    responseList.Add(res);
                }
            }
            else
            {
                var res = new ServiceResponse<PassengerDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };
                responseList.Add(res);
            }

            return responseList;    
        }

        public async Task CreateByEntity(ServiceResponse<PassengerDto> entity)
        {
            if(entity.Data != null)
            {
                var mapResult = _mapper.Map<Passenger>(entity.Data);

                await _context.Passenger.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteByName(string name)
        {
            var result = _context.Passenger.FirstOrDefault(n=>n.FirstName == name);

            if(result != null)
            {
                _context.Passenger.Remove(result);
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

        

        public Task<ServiceResponse<PassengerDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerDto>> Update(int id, ServiceResponse<PassengerDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<PassengerDto>> UpdateByEntity(ServiceResponse<PassengerDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
