using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportationOptionController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public TransportationOptionController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<TransportationOption>>>> GetAll()
        {
            var result = await _unitWork.TransportationOption.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<TransportationOption>>> Add(TransportationOptionDto entity)
        {
            var sr = new ServiceResponse<TransportationOptionDto>();
            sr.Data = entity;
            await _unitWork.TransportationOption.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<TransportationOption>>> DeleteByName(string name)
        {
            await _unitWork.TransportationOption.DeleteByName(name);
            return Ok();
        }
    }
}
