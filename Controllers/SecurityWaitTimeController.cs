using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityWaitTimeController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public SecurityWaitTimeController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<SecurityWaitTime>>>> GetAll()
        {
            var result = await _unitWork.SecurityWaitTime.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<SecurityWaitTime>>> Add(SecurityWaitTimeDto entity)
        {
            var sr = new ServiceResponse<SecurityWaitTimeDto>();
            sr.Data = entity;
            await _unitWork.SecurityWaitTime.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<SecurityWaitTime>>> DeleteById(int SecurityCheckpointId)
        {
            await _unitWork.SecurityWaitTime.DeleteById(SecurityCheckpointId);
            return Ok();
        }
    }
}
