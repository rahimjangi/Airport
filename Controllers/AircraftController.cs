using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public AircraftController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Aircraft>>>> GetAll()
        {
            var result = await _unitOfWork.Aircraft.GetAll();
            return Ok(result);
        }

        [HttpGet("/name")]
        public async Task<ActionResult<ServiceResponse<Aircraft>>> GetByName(string aircraft)
        {
            var result = await _unitOfWork.Aircraft.GetByName(aircraft);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Aircraft>>> Add(AircraftDto aircraft)
        {
            var sr = new ServiceResponse<AircraftDto>();
            sr.Data = aircraft;
            await _unitOfWork.Aircraft.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<Aircraft>> DeleteByName(string aircaftName)
        {
            await _unitOfWork.Aircraft.DeleteByName(aircaftName);
            return Ok();
        }
    }
}
