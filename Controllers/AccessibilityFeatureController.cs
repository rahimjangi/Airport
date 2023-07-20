using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessibilityFeatureController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public AccessibilityFeatureController(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<AccessibilityFeature>>> GetAll()
        {
            var result = await _unitOfWork.AccessibilityFeature.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AccessibilityFeature>>> Add(AccessibilityFeatureDto feature)
        {
            var sr = new ServiceResponse<AccessibilityFeatureDto>();
            sr.Data = feature;
            await _unitOfWork.AccessibilityFeature.CreateByEntity(sr);
            return Ok();
        }
    }
}
