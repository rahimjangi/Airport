using Airport.Data;
using Airport.Dto;
using Airport.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;

namespace Airport.Service.BookingService
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookingRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServiceResponse<BookingDto>>> GetAll()
        {
            var resultList = await _context.Bookings.ToListAsync();
            var responseList = new List<ServiceResponse<BookingDto>>();

            if(resultList.Count > 0 && resultList != null)
            {
                var mapResult = _mapper.Map<List<BookingDto>>(resultList);

                foreach(var result in mapResult)
                {
                    var res = new ServiceResponse<BookingDto>
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
                var res = new ServiceResponse<BookingDto>
                {
                    Data = null,
                    Message = "Result not found",
                    Success = false
                };

                responseList.Add(res);
            }

            return responseList;
        }
        public async Task CreateByEntity(ServiceResponse<BookingDto> entity)
        {
            if(entity.Data != null)
            {
                var mapResult = _mapper.Map<Booking>(entity.Data);
                await _context.Bookings.AddAsync(mapResult);
                await _context.SaveChangesAsync();
            }
            else
            {
                await Task.CompletedTask;
            }            
        }

        public async Task DeleteById(int id)
        {
            var result = await _context.Bookings.FirstOrDefaultAsync(n => n.FlightId.Equals(id));

            if (result != null)
            {
                _context.Bookings.Remove(result);
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
            //var result = await _context.Bookings.FirstOrDefaultAsync(n => n.FlightId.Equals(name));

            //if (result != null)
            //{
            //    _context.Bookings.Remove(result);
            //    await _context.SaveChangesAsync();
            //}
            //else
            //{
            //    await Task.CompletedTask;
            //}
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }       

        public Task<ServiceResponse<BookingDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BookingDto>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BookingDto>> Update(int id, ServiceResponse<BookingDto> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<BookingDto>> UpdateByEntity(ServiceResponse<BookingDto> entity)
        {
            throw new NotImplementedException();
        }
    }
}
