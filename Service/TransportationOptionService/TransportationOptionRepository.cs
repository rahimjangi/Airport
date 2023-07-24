using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.TransportationOptionService
{
    public class TransportationOptionRepository : ITransportationOptionRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TransportationOptionRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<TransportationOptionDto>>> GetAll()
        {
            var resultList = await _context.TransportationOption.ToListAsync();
            var responseList = new List<ServiceResponse<TransportationOptionDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<TransportationOptionDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<TransportationOptionDto>
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
                var res = new ServiceResponse<TransportationOptionDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<TransportationOptionDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<TransportationOption>(entity.Data);
                await _context.TransportationOption.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.TransportationOption.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.TransportationOption.Remove(result);
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

        public Task<ServiceResponse<TransportationOptionDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationOptionDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationOptionDto>> Update(int id, ServiceResponse<TransportationOptionDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationOptionDto>> UpdateByEntity(ServiceResponse<TransportationOptionDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
