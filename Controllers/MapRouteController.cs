using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapRouteController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitWork;

        public MapRouteController(IUnitOfWorkRepository unitWork)
        {
            _unitWork = unitWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<MapRoute>>>> GetAll()
        {
            var result = await _unitWork.MapRoute.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<MapRoute>>> Add(MapRouteDto entity)
        {
            var sr = new ServiceResponse<MapRouteDto>();
            sr.Data = entity;
            await _unitWork.MapRoute.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<MapRoute>>> DeleteById(int bookingNumber)
        {
            await _unitWork.MapRoute.DeleteById(bookingNumber);
            return Ok();
        }
    }
}
