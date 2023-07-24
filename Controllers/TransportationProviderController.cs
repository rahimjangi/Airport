using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportationProviderController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public TransportationProviderController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<TransportationProvider>>>> GetAll()
        {
            var result = await _unitWork.TransportationProvider.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<TransportationProvider>>> Add(TransportationProviderDto entity)
        {
            var sr = new ServiceResponse<TransportationProviderDto>();
            sr.Data = entity;
            await _unitWork.TransportationProvider.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<TransportationProvider>>> DeleteByName(string name)
        {
            await _unitWork.TransportationProvider.DeleteByName(name);
            return Ok();
        }
    }
}
