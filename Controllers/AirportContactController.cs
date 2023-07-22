using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportContactController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public AirportContactController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<AirportContact>>>> GetAll() 
        {
            var result = await _unitWork.AirportContact.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AirportContact>>> Add(AirportContactDto entity)
        {

            var sr = new ServiceResponse<AirportContactDto>();
            sr.Data = entity;
            await _unitWork.AirportContact.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<AirportContact>>> DeleteByName(string name)
        {
            await _unitWork.AirportContact.DeleteByName(name);
            return Ok();
        }

    }
}
