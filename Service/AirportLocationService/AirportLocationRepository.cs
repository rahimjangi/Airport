using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.AirportLocationService
{
    public class AirportLocationRepository : IAirportLocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AirportLocationRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<AirportLocationDto>>> GetAll()
        {
            var resultList = await _context.AirportLocation.ToListAsync();
            var responseList = new List<ServiceResponse<AirportLocationDto>>();

            if(resultList != null && resultList.Count > 0)
            {
                var mapResult = _mapper.Map<List<AirportLocationDto>>(resultList);

                foreach(var result in mapResult) 
                {
                    var res = new ServiceResponse<AirportLocationDto>
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
                var res = new ServiceResponse<AirportLocationDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = true
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<AirportLocationDto> entity)
        {
            if(entity.Data != null)
            {
                var mapresult = _mapper.Map<AirportLocation>(entity.Data);
                await _context.AirportLocation.AddAsync(mapresult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteByName(string name)
        {
            var result = await _context.AirportLocation.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if(result != null)
            {
                _context.AirportLocation.Remove(result);
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

        public Task<ServiceResponse<AirportLocationDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocationDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocationDto>> Update(int id, ServiceResponse<AirportLocationDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportLocationDto>> UpdateByEntity(ServiceResponse<AirportLocationDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
