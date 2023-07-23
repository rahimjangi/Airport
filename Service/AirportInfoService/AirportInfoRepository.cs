using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Airport.Service.AirportInfoService
{
    public class AirportInfoRepository : IAirportInfoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AirportInfoRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;            
        }
        public async Task<List<ServiceResponse<AirportInfoDto>>> GetAll()
        {
            var resultList = await _context.AirportInfo.ToListAsync();
            var responseList = new List<ServiceResponse<AirportInfoDto>>();

            if(resultList != null && resultList.Count > 0)
            {
                var mapResult = _mapper.Map<List<AirportInfoDto>>(resultList);

                foreach(var result in mapResult)
                {
                    var res = new ServiceResponse<AirportInfoDto>
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
                var res = new ServiceResponse<AirportInfoDto>
                {
                    Data = null,
                    Message = "Result found",
                    Success = true
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<AirportInfoDto> entity)
        {
            if(entity.Data != null)
            {
                var mapResult = _mapper.Map<AirportInfo>(entity.Data);

                await _context.AirportInfo.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }
        public async Task DeleteByName(string name)
        {
            var result = _context.AirportInfo.FirstOrDefault(n => n.Name.Equals(name));

            if(result != null)
            {
                _context.AirportInfo.Remove(result);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }
        public Task<ServiceResponse<AirportInfoDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }       

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }       

        public Task<ServiceResponse<AirportInfoDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportInfoDto>> Update(int id, ServiceResponse<AirportInfoDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportInfoDto>> UpdateByEntity(ServiceResponse<AirportInfoDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
