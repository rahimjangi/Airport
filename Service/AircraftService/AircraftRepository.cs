using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<ServiceResponse<AircraftDto>>> GetAll()
        {
            var resultList = await _context.Aircrafts.ToListAsync();
            var responseList = new List<ServiceResponse<AircraftDto>>();

            if (resultList.Count > 0 && resultList != null) 
            {
               var mapResult = _mapper.Map<List<AircraftDto>>(resultList);

                foreach(var result in mapResult)
                {
                    var response = new ServiceResponse<AircraftDto>
                    {
                        Data = result,
                        Success = true,
                        Message = "Aircraft exists."
                    };

                    responseList.Add(response);
                }
            }
            else
            {
                var response = new ServiceResponse<AircraftDto> 
                {
                    Data = null,
                    Success = false,
                    Message = "No Aircraft found."
                };

                responseList.Add(response);
            }

            return responseList;
        }

        public async Task<ServiceResponse<AircraftDto>> GetByName(string name)
        {
            ServiceResponse <AircraftDto> response = new ServiceResponse<AircraftDto>();

            var result = await _context.Aircrafts.FirstOrDefaultAsync(a => a.AircraftCode.Equals(name));

            if(result != null) 
            {
                var mapResult = _mapper.Map<AircraftDto>(result);
                response = new ServiceResponse<AircraftDto>
                {
                    Data = mapResult,
                    Success = true,
                    Message = "Aircraft found."
                };
                return response;
            }
            else
            {
                response = new ServiceResponse<AircraftDto>
                {
                    Data = null,
                    Success = false,
                    Message = "Aircraft not found."
                };

                return response;
            }
        }

        public async Task CreateByEntity(ServiceResponse<AircraftDto> entity)
        {
            if(entity.Data != null) 
            {
               var mapResult = _mapper.Map<Aircraft>(entity.Data);
               
                await _context.Aircrafts.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public  Task DeleteById(int id)
        {
            
            throw new NotImplementedException();
        }

        public async Task DeleteByName(string name)
        {
            var result = await _context.Aircrafts.FirstOrDefaultAsync(n => n.AircraftCode.Equals(name));
            if(result != null)
            {
                _context.Aircrafts.Remove(result);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }       

        public Task<ServiceResponse<AircraftDto>> GetById(int id)
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
