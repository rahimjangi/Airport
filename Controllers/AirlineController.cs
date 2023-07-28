using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public AirlineController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "ApiKeySchema")]
        public async Task<ActionResult<List<ServiceResponse<Airline>>>> GetAll()
        {
           var result =  await _unitOfWork.Airline.GetAll();

            return Ok(result);
        }

        [HttpGet("/{id}")]
        [Authorize]
        public async Task<ActionResult<ServiceResponse<Airline>>> GetById(int id)
        {
            var result= await _unitOfWork.Airline.GetById(id);
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<ActionResult<ServiceResponse<Airline>>> Add(AirlineDto airline)
        {
            var sr = new ServiceResponse<AirlineDto>();
            sr.Data = airline;
            await _unitOfWork.Airline.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Airline>>> DeleteByName(string airlineName)
        {            
            await _unitOfWork.Airline.DeleteByName(airlineName);

            return Ok();
        }
        
    }
}
