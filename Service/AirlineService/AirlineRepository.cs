using Airport.Data;
using Airport.Model;
using Azure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Timers;

namespace Airport.Service.AirlineService
{
    public class AirlineRepository : IAirlineRepository
    {
        private readonly ApplicationDbContext _context;
        ServiceResponse<Airline> _response;

        public AirlineRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceResponse<Airline>>> GetAll()
        {
            var resultList = await _context.Airlines.ToListAsync();

            var responseList = new List<ServiceResponse<Airline>>();

            if(resultList != null && resultList.Count > 0) {
                foreach (var result in resultList)
                {
                    _response = new ServiceResponse<Airline>
                    {
                        Data = result,
                        Success = true,
                        Message = "Airline found."
                    };

                    responseList.Add(_response);
                }
            }
            else {
                var response = new ServiceResponse<Airline>
                {
                    Data = null,
                    Success = false,
                    Message = "No airlines found."
                };

                responseList.Add(response);
            }
           
            return responseList;          
        }

        public async Task<ServiceResponse<Airline>> GetById(int id)
        {
            
            var result = await _context.Airlines.FirstOrDefaultAsync(a => a.Id.Equals(id));

            if(result != null)
            {
                _response = new ServiceResponse<Airline>
                {
                    Data = result,
                    Success = true,
                    Message = "Airline found."
                };
                return _response;

            }
            else
            {
                _response = new ServiceResponse<Airline>
                {
                    Data = result,
                    Success = false,
                    Message = "Airline not found."
                };
                return _response;
            }
        }

        public async Task CreateByEntity(ServiceResponse<Airline> entity)
        {
            if(entity.Data != null)
            {
                await _context.Airlines.AddAsync(entity.Data);
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

        public Task DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }

        

        public Task<ServiceResponse<Airline>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Airline>> Update(int id, ServiceResponse<Airline> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Airline>> UpdateByEntity(ServiceResponse<Airline> entity)
        {
            throw new NotImplementedException();
        }
    }
}
