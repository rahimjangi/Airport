using Airport.Controllers;
using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;

namespace Airport.Service.AirportContactService
{
    public class AirportContactRepository : IAirportContactRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AirportContactRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ServiceResponse<AirportContactDto>>> GetAll()
        {
            var resultList = await _context.AirportContact.ToListAsync();
            var responseList = new List<ServiceResponse<AirportContactDto>>();

            if(resultList != null && resultList.Count > 0)
            {
                var mapResult = _mapper.Map<List<AirportContactDto>>(resultList);

                foreach (var reslut in mapResult)
                {
                    var res = new ServiceResponse<AirportContactDto>
                    {
                        Data = reslut,
                        Message = "Result found",
                        Success = true
                    };
                    responseList.Add(res);
                }
            }
            else
            { 
                var res = new ServiceResponse<AirportContactDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };
                 responseList.Add(res);               
            }

            return responseList;            
        }

        public async Task CreateByEntity(ServiceResponse<AirportContactDto> entity)
        {
            if(entity.Data != null)
            {
                var mapResult = _mapper.Map<AirportContact>(entity.Data);
                await _context.AirportContact.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public async Task DeleteByName(string name)
        {
            var result = await _context.AirportContact.FirstOrDefaultAsync(n=>n.Name == name);

            if(result != null)
            {
                _context.AirportContact.Remove(result);
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
        
        public Task<ServiceResponse<AirportContactDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportContactDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportContactDto>> Update(int id, ServiceResponse<AirportContactDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AirportContactDto>> UpdateByEntity(ServiceResponse<AirportContactDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
