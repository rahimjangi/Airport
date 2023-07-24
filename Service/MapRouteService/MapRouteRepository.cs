using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.MapRouteService
{
    public class MapRouteRepository : IMapRouteRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MapRouteRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<MapRouteDto>>> GetAll()
        {
            var resultList = await _context.MapRoute.ToListAsync();
            var responseList = new List<ServiceResponse<MapRouteDto>>();

            if (resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<MapRouteDto>>(resultList);

                foreach (var result in mapResult)
                {
                    var res = new ServiceResponse<MapRouteDto>
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
                var res = new ServiceResponse<MapRouteDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<MapRouteDto> entity)
        {
            if (entity.Data != null)
            {
                var mapResult = _mapper.Map<MapRoute>(entity.Data);
                await _context.MapRoute.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.MapRoute.FirstOrDefaultAsync(n => n.StartLocationId.Equals(id));

            if (result != null)
            {
                _context.MapRoute.Remove(result);
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
       
        public Task<ServiceResponse<MapRouteDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<MapRouteDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<MapRouteDto>> Update(int id, ServiceResponse<MapRouteDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<MapRouteDto>> UpdateByEntity(ServiceResponse<MapRouteDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
