using ECMS.Context;
using ECMS.DTO.Auth;
using ECMS.Models;
using ECMS.Services;
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
        private readonly JwtTokenGenerator _tokenGenerator;
        private readonly PasswordHasher<Person> _passwordHasher;

        public AuthController(ApplicationContext context, JwtTokenGenerator tokenGenerator)
        {
            _context = context;
            _tokenGenerator = tokenGenerator;
            _passwordHasher = new PasswordHasher<Person>();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var person = await _context.Persons
                .FirstOrDefaultAsync(u => u.UserName == request.UserName);

            if (person == null || _passwordHasher.VerifyHashedPassword(person, person.PasswordHash, request.Password) == PasswordVerificationResult.Failed)
                return Unauthorized();

            var token = _tokenGenerator.GenerateToken(person);

            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (await _context.Persons.AnyAsync(u => u.UserName == request.UserName))
                return BadRequest("Username already exists");

            var person = new Person
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Role = request.Role
            };

            person.PasswordHash = _passwordHasher.HashPassword(person, request.Password);

            var customer = new Customer
            {
                Person = person,
                DateOfBirth = request.DateOfBirth,
                JoinDate = DateTime.Now,
                LastVisit = DateTime.Now
            };

            _context.Persons.Add(person);
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            var token = _tokenGenerator.GenerateToken(person);

            return Ok(new { Token = token });
        }
    }
}
