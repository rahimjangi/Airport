using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInRequestController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public CheckInRequestController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<CheckInRequest>>>> GetAll()
        {
            var result = await _unitWork.CheckInRequest.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<CheckInRequest>>> Add(CheckInRequestDto entity)
        {
            var sr = new ServiceResponse<CheckInRequestDto>();
            sr.Data = entity;
            await _unitWork.CheckInRequest.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<CheckInRequest>>> DeleteById(string bookingNumber)
        {
            await _unitWork.CheckInRequest.DeleteByName(bookingNumber);
            return Ok();
        }
    }
}
