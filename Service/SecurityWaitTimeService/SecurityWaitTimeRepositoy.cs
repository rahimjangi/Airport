using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.SecurityWaitTimeService
{
    public class SecurityWaitTimeRepositoy : ISecurityWaitTimeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SecurityWaitTimeRepositoy(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<List<ServiceResponse<SecurityWaitTimeDto>>> GetAll()
        {
            var resultList = await _context.SecurityWaitTime.ToListAsync();
            var responseList = new List<ServiceResponse<SecurityWaitTimeDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<SecurityWaitTimeDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<SecurityWaitTimeDto>
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
                var res = new ServiceResponse<SecurityWaitTimeDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<SecurityWaitTimeDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<SecurityWaitTime>(entity.Data);
                await _context.SecurityWaitTime.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.SecurityWaitTime.FirstOrDefaultAsync(n => n.SecurityCheckpointId.Equals(id));

            if (result != null)
            {
                _context.SecurityWaitTime.Remove(result);
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
        public Task<ServiceResponse<SecurityWaitTimeDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SecurityWaitTimeDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SecurityWaitTimeDto>> Update(int id, ServiceResponse<SecurityWaitTimeDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SecurityWaitTimeDto>> UpdateByEntity(ServiceResponse<SecurityWaitTimeDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
