using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public TranslationController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Translation>>>> GetAll()
        {
            var result = await _unitWork.Translation.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Translation>>> Add(TranslationDto entity)
        {
            var sr = new ServiceResponse<TranslationDto>();
            sr.Data = entity;
            await _unitWork.Translation.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<Translation>>> DeleteById(int languageId)
        {
            await _unitWork.Translation.DeleteById(languageId);
            return Ok();
        }
    }
}
