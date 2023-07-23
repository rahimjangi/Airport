using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyProgramController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public LoyaltyProgramController(IUnitOfWorkRepository unitWork)
        {
            _unitOfWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<LoyaltyProgram>>>> GetAll()
        {
            var result = await _unitOfWork.LoyaltyProgram.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<LoyaltyProgram>>> CreateByEntity(LoyaltyProgramDto entity)
        {
            var sr = new ServiceResponse<LoyaltyProgramDto>();
            sr.Data = entity;
            await _unitOfWork.LoyaltyProgram.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<LoyaltyProgram>>> DeleteById(int passengerId)
        {
            await _unitOfWork.LoyaltyProgram.DeleteById(passengerId);
            return Ok();
        }
    }
}
