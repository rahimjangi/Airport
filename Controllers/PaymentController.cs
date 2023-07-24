using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public PaymentController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Payment>>>> GetAll()
        {
            var result = await _unitWork.Payment.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Payment>>> Add(PaymentDto entity)
        {
            var sr = new ServiceResponse<PaymentDto>();
            sr.Data = entity;
            await _unitWork.Payment.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<Payment>>> DeleteById(int bookingId)
        {
            await _unitWork.Payment.DeleteById(bookingId);
            return Ok();
        }
    }
}
