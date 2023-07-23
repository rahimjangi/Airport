using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportLocationController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;
        public AirportLocationController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<AirportLocation>>>> GetAll()
        {
            var result = await _unitWork.AirportLocation.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AirportLocation>>> Add(AirportLocationDto airportLocation)
        {
            var sr = new ServiceResponse<AirportLocationDto>();
            sr.Data = airportLocation;
            await _unitWork.AirportLocation.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<AirportLocation>>> DeleteByname(string name)
        {
            await _unitWork.AirportLocation.DeleteByName(name);
            return Ok();
        }
    }
}
