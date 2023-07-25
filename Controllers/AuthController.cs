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
        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            // Validate username and password (you can use your authentication logic here)
            // If valid, create claims
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                // Add other claims as needed, e.g., roles, permissions, etc.
            };

            // Generate token
            var jwtSecretKey = "your-secret-key"; // Use the same secret key as configured above
            var token = new JwtSecurityToken(
                issuer: "your-issuer",
                audience: "your-audience",
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(15), // Set token expiration time
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecretKey)), SecurityAlgorithms.HmacSha256)
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            // Return token in the API response
            return Ok(new { Token = tokenString });
        }
    }
}
