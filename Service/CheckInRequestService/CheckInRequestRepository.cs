using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.CheckInRequestService
{
    public class CheckInRequestRepository : ICheckInRequestRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CheckInRequestRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<CheckInRequestDto>>> GetAll()
        {
            var resultList = await _context.CheckInRequest.ToListAsync();
            var responseList = new List<ServiceResponse<CheckInRequestDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<CheckInRequestDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<CheckInRequestDto>
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
                var res = new ServiceResponse<CheckInRequestDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<CheckInRequestDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<CheckInRequest>(entity.Data);
                await _context.CheckInRequest.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.CheckInRequest.FirstOrDefaultAsync(n => n.FlightNumber.Equals(name));

            if (result != null)
            {
                _context.CheckInRequest.Remove(result);
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

        public Task<ServiceResponse<CheckInRequestDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CheckInRequestDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CheckInRequestDto>> Update(int id, ServiceResponse<CheckInRequestDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CheckInRequestDto>> UpdateByEntity(ServiceResponse<CheckInRequestDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
