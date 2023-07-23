using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.AirportAmenityService
{
    public class AirportAmenityRepository : IAirportAmenityRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AirportAmenityRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<List<ServiceResponse<AirportAmenityDto>>> GetAll()
        {
            var resultList = await _context.AirportAmenity.ToListAsync();
            var responseList = new List<ServiceResponse<AirportAmenityDto>>();

            if(resultList != null && responseList.Count > 0)
            {
                var mapResultList = _mapper.Map<List<AirportAmenityDto>>(resultList);

                foreach(var result in mapResultList)
                {
                    var res = new ServiceResponse<AirportAmenityDto>
                    {
                        Data = result,
                        Message = "Result found.",
                        Success = true
                    };

                    responseList.Add(res);
                }
            }
            else
            {
                var res = new ServiceResponse<AirportAmenityDto>
                {
                    Data = null,
                    Message = "Result not found.",
                    Success = false
                };

                 responseList.Add(res);                
            }

            return responseList;
        }

        public async Task CreateByEntity(ServiceResponse<AirportAmenityDto> entity)
        {
            if (entity != null) 
            {
                var mapResult = _mapper.Map<AirportAmenity>(entity.Data);

                _context.AirportAmenity.Add(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
           
        }

        public async Task DeleteByName(string name)
        {
            var result = _context.AirportAmenity.FirstOrDefault(n => n.Name.Equals(name));

            if (result != null)
            {
                _context.AirportAmenity.Remove(result);
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

        public Task<ServiceResponse<AirportAmenityDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenityDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenityDto>> Update(int id, ServiceResponse<AirportAmenityDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportAmenityDto>> UpdateByEntity(ServiceResponse<AirportAmenityDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
