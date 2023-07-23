using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.CountryService
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CountryRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<CountryDto>>> GetAll()
        {
            var resultList = await _context.Country.ToListAsync();
            var responseList = new List<ServiceResponse<CountryDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<CountryDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<CountryDto>
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
                var res = new ServiceResponse<CountryDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<CountryDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<Country>(entity.Data);
                await _context.Country.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.Country.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.Country.Remove(result);
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

        public Task<ServiceResponse<CountryDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CountryDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CountryDto>> Update(int id, ServiceResponse<CountryDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CountryDto>> UpdateByEntity(ServiceResponse<CountryDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
