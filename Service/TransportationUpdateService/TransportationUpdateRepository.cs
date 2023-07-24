using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.TransportationUpdateService
{
    public class TransportationUpdateRepository : ITransportationUpdateRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TransportationUpdateRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<TransportationUpdateDto>>> GetAll()
        {
            var resultList = await _context.TransportationUpdate.ToListAsync();
            var responseList = new List<ServiceResponse<TransportationUpdateDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<TransportationUpdateDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<TransportationUpdateDto>
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
                var res = new ServiceResponse<TransportationUpdateDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<TransportationUpdateDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<TransportationUpdate>(entity.Data);
                await _context.TransportationUpdate.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.TransportationUpdate.FirstOrDefaultAsync(n => n.TransportationProviderId.Equals(id));

            if (result != null)
            {
                _context.TransportationUpdate.Remove(result);
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
        public Task<ServiceResponse<TransportationUpdateDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationUpdateDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationUpdateDto>> Update(int id, ServiceResponse<TransportationUpdateDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationUpdateDto>> UpdateByEntity(ServiceResponse<TransportationUpdateDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
