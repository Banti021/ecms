using ECMS.Context;
using ECMS.DTO.Auth;
using ECMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly PasswordHasher<Person> _passwordHasher;

        public AuthController(ApplicationContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<Person>();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var person = await _context.Persons
                .FirstOrDefaultAsync(u => u.UserName == request.UserName);

            if (person == null || _passwordHasher.VerifyHashedPassword(person, person.PasswordHash, request.Password) == PasswordVerificationResult.Failed)
                return Unauthorized(new { message = "Invalid username or password" });
            
            return Ok(person);
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
            
            return Ok(person);
        }
    }
}
