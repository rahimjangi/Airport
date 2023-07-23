using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public CountryController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Country>>>> GetAll()
        {
            var result = await _unitWork.City.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Country>>> Add(CountryDto entity)
        {
            var sr = new ServiceResponse<CountryDto>();
            sr.Data = entity;
            await _unitWork.Country.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Country>>> DeleteById(int bookingNumber)
        {
            await _unitWork.City.DeleteById(bookingNumber);
            return Ok();
        }
    }
}
