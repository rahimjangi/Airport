using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportInfoController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public AirportInfoController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<AirportInfo>>>> GetAll()
        {
            var result = await _unitWork.AirportInfo.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<ServiceResponse<AirportInfo>>>> Add(AirportInfoDto entity)
        {
            var rs = new ServiceResponse<AirportInfoDto>();
            rs.Data = entity;
            await _unitWork.AirportInfo.CreateByEntity(rs);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<AirportInfo>>> DeleteByName(string name)
        {
            await _unitWork.AirportInfo.DeleteByName(name);
            return Ok();
        }

    }
}
