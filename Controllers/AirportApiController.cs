using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportApiController : ControllerBase
    {
        [HttpGet]
        [Authorize] // Add this attribute to require authentication for this action
        public IActionResult ProtectedEndpoint()
        {
            // Your protected API action here
            return Ok(new { });
        }
    }
}
