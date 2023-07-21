using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Airport.Service.AccessibilityFeatureService
{
    public class AccessibilityFeatureRepository : IAccessibilityFeatureRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public AccessibilityFeatureRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
           _mapper = mapper;
            _context = applicationDbContext;
        }

        public async Task<List<ServiceResponse<AccessibilityFeatureDto>>> GetAll()
        {
            var resultList = await _context.AccessibilityFeature.ToListAsync();
            var responseList = new List<ServiceResponse<AccessibilityFeatureDto>>();

            if(resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<AccessibilityFeatureDto>>(resultList);
                foreach (var result in mapResult)
                {
                    var response = new ServiceResponse<AccessibilityFeatureDto>
                    {
                        Data = result,
                        Message = "Result exists",
                        Success = true
                    };

                    responseList.Add(response);
                }
            }
            else
            {
                await Task.CompletedTask;
            }

            return responseList;
        }

        public async Task CreateByEntity(ServiceResponse<AccessibilityFeatureDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<AccessibilityFeature>(entity.Data);
            
                await _context.AccessibilityFeature.AddAsync(mapResult);
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

        public async Task DeleteByName(string name)
        {
            var result = await _context.AccessibilityFeature.FirstOrDefaultAsync(x => x.Name == name);

            if (result != null)
            {
                _context.AccessibilityFeature.Remove(result);
                _context.SaveChanges();
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

        public Task<ServiceResponse<AccessibilityFeatureDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeatureDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeatureDto>> Update(int id, ServiceResponse<AccessibilityFeatureDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeatureDto>> UpdateByEntity(ServiceResponse<AccessibilityFeatureDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
