using Airport.Data;
using Airport.Dto;
using Airport.Model;
using Airport.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
            private readonly IUnitOfWorkRepository _unitOfWork;

            public FlightController(IUnitOfWorkRepository unitWork)
            {
                _unitOfWork = unitWork;
            }

            [HttpGet]
            public async Task<ActionResult<List<ServiceResponse<Flight>>>> GetAll()
            {
                var result = await _unitOfWork.Flight.GetAll();
                return Ok(result);
            }

            [HttpPost]
            public async Task<ActionResult<ServiceResponse<Flight>>> CreateByEntity(FlightDto baggage)
            {
                var sr = new ServiceResponse<FlightDto>();
                sr.Data = baggage;
                await _unitOfWork.Flight.CreateByEntity(sr);
                return Ok();
            }

            [HttpDelete]
            public async Task<ActionResult<ServiceResponse<Flight>>> DeleteByName(string flightNumbber)
            {
                await _unitOfWork.Flight.DeleteByName(flightNumbber);
                return Ok();
            }
    }
}
