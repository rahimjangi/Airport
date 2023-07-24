using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.TranslationService
{
    public class TranslationRepository : ITranslationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TranslationRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<TranslationDto>>> GetAll()
        {
            var resultList = await _context.Translation.ToListAsync();
            var responseList = new List<ServiceResponse<TranslationDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<TranslationDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<TranslationDto>
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
                var res = new ServiceResponse<TranslationDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<TranslationDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<Translation>(entity.Data);
                await _context.Translation.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.Translation.FirstOrDefaultAsync(n => n.LanguageId.Equals(id));

            if (result != null)
            {
                _context.Translation.Remove(result);
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

        public Task<ServiceResponse<TranslationDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TranslationDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TranslationDto>> Update(int id, ServiceResponse<TranslationDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TranslationDto>> UpdateByEntity(ServiceResponse<TranslationDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
