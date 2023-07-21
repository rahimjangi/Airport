using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.AccessibilityOptionService
{
    public class AccessibilityOptionRepository : IAccessibilityOptionRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AccessibilityOptionRepository(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateByEntity(ServiceResponse<AccessibilityOptionDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult =  _mapper.Map<AccessibilityOption>(entity.Data);
                await _context.AccessibilityOption.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task<List<ServiceResponse<AccessibilityOptionDto>>> GetAll()
        {
            var resultList = await _context.AccessibilityOption.ToListAsync();
            var responseList = new List<ServiceResponse<AccessibilityOptionDto>>();

            if(resultList != null && resultList.Count > 0) 
            {
                var mapResult = _mapper.Map<List<AccessibilityOptionDto>>(resultList);

                foreach(var result in mapResult)
                {
                    var res = new ServiceResponse<AccessibilityOptionDto>
                    {
                        Data = result,
                        Message = "Result Foinded",
                        Success = true
                    };

                    responseList.Add(res);
                }
            }
            else
            {
                var response = new ServiceResponse<AccessibilityOptionDto>
                {
                    Data = null,
                    Success = false,
                    Message = "Result not found."
                };

                responseList.Add(response);
            }

            return responseList ;

        }

        public async Task DeleteByName(string name)
        {
            var result = await _context.AccessibilityOption.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if(result != null)
            {
                _context.AccessibilityOption.Remove(result);
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

        public Task<ServiceResponse<AccessibilityOptionDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOptionDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOptionDto>> Update(int id, ServiceResponse<AccessibilityOptionDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOptionDto>> UpdateByEntity(ServiceResponse<AccessibilityOptionDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
