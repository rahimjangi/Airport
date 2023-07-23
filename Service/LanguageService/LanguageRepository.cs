using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.LanguageService
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LanguageRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<LanguageDto>>> GetAll()
        {
            var resultList = await _context.Language.ToListAsync();
            var responseList = new List<ServiceResponse<LanguageDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<LanguageDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<LanguageDto>
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
                var res = new ServiceResponse<LanguageDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<LanguageDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<Language>(entity.Data);
                await _context.Language.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.Language.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.Language.Remove(result);
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

        public Task<ServiceResponse<LanguageDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LanguageDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LanguageDto>> Update(int id, ServiceResponse<LanguageDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LanguageDto>> UpdateByEntity(ServiceResponse<LanguageDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
