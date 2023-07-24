using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.TransportationProviderService
{
    public class TransportationProviderRepository : ITransportationProviderRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TransportationProviderRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<TransportationProviderDto>>> GetAll()
        {
            var resultList = await _context.TransportationProvider.ToListAsync();
            var responseList = new List<ServiceResponse<TransportationProviderDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<TransportationProviderDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<TransportationProviderDto>
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
                var res = new ServiceResponse<TransportationProviderDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<TransportationProviderDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<TransportationProvider>(entity.Data);
                await _context.TransportationProvider.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            };
        }
        public async Task DeleteByName(string name)
        {
            var result = await _context.TransportationProvider.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.TransportationProvider.Remove(result);
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

        public Task<ServiceResponse<TransportationProviderDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationProviderDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationProviderDto>> Update(int id, ServiceResponse<TransportationProviderDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TransportationProviderDto>> UpdateByEntity(ServiceResponse<TransportationProviderDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
