using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace Airport.Service.AirlineService
{
    public class AirlineRepository : IAirlineRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AirlineRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<AirlineDto>>> GetAll()
        {
            ServiceResponse<AirlineDto> _response = new ServiceResponse<AirlineDto>();
            var resultList = await _context.Airlines.ToListAsync();

            var responseList = new List<ServiceResponse<AirlineDto>>();

            if(resultList != null && resultList.Count > 0) {

                var mapResults = _mapper.Map<List<AirlineDto>>(resultList);

                foreach (var mapResult in mapResults)
                {
                    _response = new ServiceResponse<AirlineDto>
                    {
                        Data = mapResult,
                        Success = true,
                        Message = "Airline found."
                    };

                    responseList.Add(_response);
                }
            }
            else {
                var response = new ServiceResponse<AirlineDto>
                {
                    Data = null,
                    Success = false,
                    Message = "No airlines found."
                };

                responseList.Add(response);
            }
           
            return responseList;          
        }

        public async Task<ServiceResponse<AirlineDto>> GetById(int id)
        {
            ServiceResponse<AirlineDto> _response = new ServiceResponse<AirlineDto>();

            var result = await _context.Airlines.FirstOrDefaultAsync(a => a.Id.Equals(id));

            if(result != null)
            {
                var resultMap = _mapper.Map<AirlineDto>(result);
                _response = new ServiceResponse<AirlineDto>
                {
                    Data = resultMap,
                    Success = true,
                    Message = "Airline found."
                };
                return _response;

            }
            else
            {
                _response = new ServiceResponse<AirlineDto>
                {
                    Data = null,
                    Success = false,
                    Message = "Airline not found."
                };
                return _response;
            }
        }

        public async Task CreateByEntity(ServiceResponse<AirlineDto> entity)
        {
            if(entity.Data != null)
            {
                var mapResult = _mapper.Map<Airline>(entity.Data);

                await _context.Airlines.AddAsync(mapResult);
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

        public async Task DeleteByName(string name)
        {
            var result = await _context.Airlines.FirstOrDefaultAsync(n => n.Name.Equals(name));

            if(result != null)
            {               
                _context.Airlines.Remove(result);
                await _context.SaveChangesAsync();
            }

        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }

        

        public Task<ServiceResponse<AirlineDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirlineDto>> Update(int id, ServiceResponse<AirlineDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirlineDto>> UpdateByEntity(ServiceResponse<AirlineDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
