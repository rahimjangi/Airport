using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.CityService
{
    public class CityRepository : ICityRepository
    {       
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CityRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<CityDto>>> GetAll()
        {
            var resultList = await _context.City.ToListAsync();
            var responseList = new List<ServiceResponse<CityDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<CityDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<CityDto>
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
                var res = new ServiceResponse<CityDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<CityDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<City>(entity.Data);
                await _context.City.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteByName(string name)
        {
            var result = await _context.City.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.City.Remove(result);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CityDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CityDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CityDto>> Update(int id, ServiceResponse<CityDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CityDto>> UpdateByEntity(ServiceResponse<CityDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
