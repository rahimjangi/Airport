using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public CityController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<City>>>> GetAll()
        {
            var result = await _unitWork.City.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<City>>> Add(CityDto entity)
        {
            var sr = new ServiceResponse<CityDto>();
            sr.Data = entity;
            await _unitWork.City.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<City>>> DeleteByName(string cityName)
        {
            await _unitWork.City.DeleteByName(cityName);
            return Ok();
        }
    }
}
