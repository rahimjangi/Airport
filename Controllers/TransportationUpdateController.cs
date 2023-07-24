using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportationUpdateController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public TransportationUpdateController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<TransportationUpdate>>>> GetAll()
        {
            var result = await _unitWork.TransportationUpdate.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<TransportationUpdate>>> Add(TransportationUpdateDto entity)
        {
            var sr = new ServiceResponse<TransportationUpdateDto>();
            sr.Data = entity;
            await _unitWork.TransportationUpdate.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<TransportationUpdate>>> DeleteById(int id)
        {
            await _unitWork.TransportationUpdate.DeleteById(id);
            return Ok();
        }
    }
}
