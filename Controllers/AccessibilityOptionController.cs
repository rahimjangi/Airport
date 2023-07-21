using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessibilityOptionController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public AccessibilityOptionController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AccessibilityOption>>> Add(AccessibilityOptionDto entity)
        {
            var sr = new ServiceResponse<AccessibilityOptionDto>();
            sr.Data = entity;
            await _unitWork.AccessibilityOption.CreateByEntity(sr);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<AccessibilityOption>>>> GetAll()
        {
            var result = await _unitWork.AccessibilityOption.GetAll();
            return Ok(result);
        }

        [HttpDelete("")]
        public async Task DeleteByName(string name)
        {
            await _unitWork.AccessibilityOption.DeleteByName(name);

        }

    }
}
