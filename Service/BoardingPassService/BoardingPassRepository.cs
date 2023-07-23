using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.BoardingPassService
{
    public class BoardingPassRepository : IBoardingPassRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BoardingPassRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<BoardingPassDto>>> GetAll()
        {
            var resultList = await _context.BoardingPass.ToListAsync();
            var responseList = new List<ServiceResponse<BoardingPassDto>>();

            if (resultList != null && resultList.Count > 0)
            {
                var mapResult = _mapper.Map<List<BoardingPassDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<BoardingPassDto>
                    {
                        Data = result,
                        Message = "Result found",
                        Success = true
                    };

                    responseList.Add(res);
                }
            }
            else
            {
                var res = new ServiceResponse<BoardingPassDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = true
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<BoardingPassDto> entity)
        {
            if (entity.Data != null)
            {
                var mapresult = _mapper.Map<BoardingPass>(entity.Data);
                await _context.BoardingPass.AddAsync(mapresult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.BoardingPass.FirstOrDefaultAsync(n => n.FlightNumber.Equals(name));

            if (result != null)
            {
                _context.BoardingPass.Remove(result);
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

        public Task<ServiceResponse<BoardingPassDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BoardingPassDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BoardingPassDto>> Update(int id, ServiceResponse<BoardingPassDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BoardingPassDto>> UpdateByEntity(ServiceResponse<BoardingPassDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
