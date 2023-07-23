using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.LoyaltyProgramService
{
    public class LoyaltyProgramRepository : ILoyaltyProgramRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LoyaltyProgramRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<LoyaltyProgramDto>>> GetAll()
        {
            var resultList = await _context.LoyaltyPrograms.ToListAsync();
            var responseList = new List<ServiceResponse<LoyaltyProgramDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<LoyaltyProgramDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<LoyaltyProgramDto>
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
                var res = new ServiceResponse<LoyaltyProgramDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<LoyaltyProgramDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<LoyaltyProgram>(entity.Data);
                await _context.LoyaltyPrograms.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.LoyaltyPrograms.FirstOrDefaultAsync(i=> i.PassengerId.Equals(id));

            if (result != null)
            {
                _context.LoyaltyPrograms.Remove(result);
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

        public Task<ServiceResponse<LoyaltyProgramDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LoyaltyProgramDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LoyaltyProgramDto>> Update(int id, ServiceResponse<LoyaltyProgramDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LoyaltyProgramDto>> UpdateByEntity(ServiceResponse<LoyaltyProgramDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
