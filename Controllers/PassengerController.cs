using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public PassengerController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Passenger>>>> GetAll()
        {
            var result = await _unitOfWork.Passenger.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Passenger>>> CreateByEntity(PassengerDto passenger)
        {
            var sr = new ServiceResponse<PassengerDto>();
            sr.Data = passenger;
            await _unitOfWork.Passenger.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Passenger>>> DeleteByName(string passengerName)
        {
            await _unitOfWork.Passenger.DeleteByName(passengerName);
            return Ok();
        }
    }
}
