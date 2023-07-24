using Airport.Dto;
using Airport.Model;
using Airport.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardingPassController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public BoardingPassController(IUnitOfWorkRepository unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServiceResponse<Passenger>>>> GetAll()
        {
            var result = await _unitOfWork.BoardingPass.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Passenger>>> CreateByEntity(BoardingPassDto boardingPass)
        {
            var sr = new ServiceResponse<BoardingPassDto>();
            sr.Data = boardingPass;
            await _unitOfWork.BoardingPass.CreateByEntity(sr);
            return Ok();
        }

        [HttpDelete("")]
        public async Task<ActionResult<ServiceResponse<Passenger>>> DeleteByName(string flightNumber)
        {
            await _unitOfWork.BoardingPass.DeleteByName(flightNumber);
            return Ok();
        }
    }
}
