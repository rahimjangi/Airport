using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightNotificationController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public FlightNotificationController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<FlightNotificatione>>>> GetAll()
        {
            var result = await _unitWork.FlightNotification.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FlightNotificatione>>> Add(FlightNotificationeDto entity)
        {
            var sr = new ServiceResponse<FlightNotificationeDto>();
            sr.Data = entity;
            await _unitWork.FlightNotification.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<FlightNotificatione>>> DeleteByName(string flightNumber)
        {
            await _unitWork.FlightNotification.DeleteByName(flightNumber);
            return Ok();
        }
    }
}
