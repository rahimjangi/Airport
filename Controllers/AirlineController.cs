using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public AirlineController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Airline>>>> GetAll()
        {
           var result =  await _unitOfWork.Airline.GetAll();

            return Ok(result);
        }

    }
}
