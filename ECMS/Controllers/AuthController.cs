using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ECMS.Context;
using ECMS.DTO.Auth;
using ECMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IConfiguration _configuration;
        private readonly PasswordHasher<Person> _passwordHasher;

        public AuthController(ApplicationContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _passwordHasher = new PasswordHasher<Person>();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(u => u.UserName == request.UserName);
            if (person == null || _passwordHasher.VerifyHashedPassword(person, person.PasswordHash, request.Password) == PasswordVerificationResult.Failed)
                return Unauthorized(new { message = "Invalid username or password" });

            var token = GenerateJwtToken(person);
            return Ok(new { user = person, token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (await _context.Persons.AnyAsync(u => u.UserName == request.UserName))
                return BadRequest(new { message = "Username already exists" });

            var person = new Person
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Role = request.Role,
                PasswordHash = _passwordHasher.HashPassword(null, request.Password)
            };

            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            
            var token = GenerateJwtToken(person);
            return Ok(new { user = person, token });
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
                return Unauthorized();

            var person = await _context.Persons.FirstOrDefaultAsync(p => p.Id == int.Parse(userId));
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        private string GenerateJwtToken(Person person)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, person.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, person.Id.ToString()),
                new Claim(ClaimTypes.Name, person.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
