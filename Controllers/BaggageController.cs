using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaggageController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public BaggageController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Baggage>>>> GetAll()
        {
            var result = await _unitOfWork.Baggage.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Baggage>>> CreateByEntity(BaggageDto baggage)
        {
            var sr = new ServiceResponse<BaggageDto>();
            sr.Data = baggage;
            await _unitOfWork.Baggage.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<Baggage>>> DeleteByName(string baggageTagNumber)
        {
            await _unitOfWork.Baggage.DeleteByName(baggageTagNumber);
            return Ok();
        }
    }
}
