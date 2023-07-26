using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SymmetricSecurityKey _securityKey;
        public AuthController()
        {
            _securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key_here"));
        }


        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {

            // Authenticate user and get the user's unique identifier and role
            var userId = "user123";
            var userRole = "admin";

            // Step 2: Create the Payload
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(ClaimTypes.Role, userRole),
                // You can add more claims as needed, such as name, email, etc.
            };

            // Step 3: Create the Header
            var signingCredentials = new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signingCredentials);

            // Step 4: Combine Header and Payload
            var payload = new JwtPayload(claims);
            var jwtToken = new JwtSecurityToken(header, payload);
            var tokenHandler = new JwtSecurityTokenHandler();

            // Step 5: Sign the Token and get the complete JWT
            string token = tokenHandler.WriteToken(jwtToken);

            // Return the token as part of the response, you might also return other user-related information
            return Ok(new { Token = token });

        }
    }
}
