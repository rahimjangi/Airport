using Airport.Data;
using Airport.Dto;
using AutoMapper;

namespace Airport.Service.AircraftService
{
    public class AircraftRepository : IAircraftRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AircraftRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task CreateByEntity(ServiceResponse<AircraftDto> entity)
        {
            throw new NotImplementedException();
        }

        public  Task DeleteById(int id)
        {
            
            throw new NotImplementedException();
        }

        public Task DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceResponse<AircraftDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AircraftDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AircraftDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AircraftDto>> Update(int id, ServiceResponse<AircraftDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AircraftDto>> UpdateByEntity(ServiceResponse<AircraftDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
