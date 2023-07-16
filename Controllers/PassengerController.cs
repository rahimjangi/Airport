using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public PassengerController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpPost]
        public Task<ActionResult<ServiceResponse<Passenger>>> CreateByEntity(Passenger passenger)
        {
            var result = _unitOfWork.Passenger.CreateByEntity(passenger);

            if (result == null)
            {
                return Task.FromResult<ActionResult<ServiceResponse<Passenger>>>(BadRequest());
            }
            else
            {
                return Task.FromResult<ActionResult<ServiceResponse<Passenger>>>(Ok(result));
            }
        }
    }
}
