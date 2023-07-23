using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public BookingController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Booking>>>> GetAll()
        {
            var result = await _unitWork.Booking.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Booking>>> Add(BookingDto entity)
        {
            var sr = new ServiceResponse<BookingDto>();
            sr.Data = entity;
            await _unitWork.Booking.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Booking>>> DeleteById(int bookingNumber)
        {
            await _unitWork.Booking.DeleteById(bookingNumber);
            return Ok();
        }
    }
}
