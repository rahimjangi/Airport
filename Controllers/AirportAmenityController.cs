using Airport.Model;
using Airport.Dto;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportAmenityController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public AirportAmenityController(IUnitOfWorkRepository unitOfWork)
        {
            _unitWork = unitOfWork;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AirportAmenity>>> Add(AirportAmenityDto airportAmenity)
        {
            var sr = new ServiceResponse<AirportAmenityDto>();
            sr.Data = airportAmenity;
            await _unitWork.AirportAmenity.CreateByEntity(sr);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<AirportAmenity>>>> GetAll()
        {
            var result = await _unitWork.AirportAmenity.GetAll();
            return Ok(result);
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<AirportAmenity>>> DeleteByName(string name)
        {
            await _unitWork.AirportAmenity.DeleteByName(name);
            return Ok();
        }
    }
}
