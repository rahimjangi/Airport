using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.SecurityCheckpointService
{
    public class SecurityCheckpointRepository : ISecurityCheckpointRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SecurityCheckpointRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<SecurityCheckpointDto>>> GetAll()
        {
            var resultList = await _context.SecurityCheckpoint.ToListAsync();
            var responseList = new List<ServiceResponse<SecurityCheckpointDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<SecurityCheckpointDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<SecurityCheckpointDto>
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
                var res = new ServiceResponse<SecurityCheckpointDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<SecurityCheckpointDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<SecurityCheckpoint>(entity.Data);
                await _context.SecurityCheckpoint.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.SecurityCheckpoint.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.SecurityCheckpoint.Remove(result);
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

        public Task<ServiceResponse<SecurityCheckpointDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SecurityCheckpointDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SecurityCheckpointDto>> Update(int id, ServiceResponse<SecurityCheckpointDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SecurityCheckpointDto>> UpdateByEntity(ServiceResponse<SecurityCheckpointDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
