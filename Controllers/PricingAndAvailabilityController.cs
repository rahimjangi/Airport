using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingAndAvailabilityController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public PricingAndAvailabilityController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<PricingAndAvailability>>>> GetAll()
        {
            var result = await _unitWork.PricingAndAvailability.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<PricingAndAvailability>>> Add(PricingAndAvailabilityDto entity)
        {
            var sr = new ServiceResponse<PricingAndAvailabilityDto>();
            sr.Data = entity;
            await _unitWork.PricingAndAvailability.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<PricingAndAvailability>>> DeleteById(int bookingId)
        {
            await _unitWork.PricingAndAvailability.DeleteById(bookingId);
            return Ok();
        }
    }
}
