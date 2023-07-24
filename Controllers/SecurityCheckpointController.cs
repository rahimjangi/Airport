using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityCheckpointController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public SecurityCheckpointController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<SecurityCheckpoint>>>> GetAll()
        {
            var result = await _unitWork.SecurityCheckpoint.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<SecurityCheckpoint>>> Add(SecurityCheckpointDto entity)
        {
            var sr = new ServiceResponse<SecurityCheckpointDto>();
            sr.Data = entity;
            await _unitWork.SecurityCheckpoint.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<SecurityCheckpoint>>> DeleteByname(string name)
        {
            await _unitWork.SecurityCheckpoint.DeleteByName(name);
            return Ok();
        }
    }
}
