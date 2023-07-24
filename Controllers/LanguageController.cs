using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public LanguageController(IUnitOfWorkRepository unitWork)
        {
            _unitOfWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Language>>>> GetAll()
        {
            var result = await _unitOfWork.Language.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Language>>> CreateByEntity(LanguageDto baggage)
        {
            var sr = new ServiceResponse<LanguageDto>();
            sr.Data = baggage;
            await _unitOfWork.Language.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<Language>>> DeleteByName(string flightNumbber)
        {
            await _unitOfWork.Language.DeleteByName(flightNumbber);
            return Ok();
        }
    }
}
