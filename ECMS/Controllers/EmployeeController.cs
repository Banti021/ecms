using ECMS.DTO;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id, CancellationToken token)
        {
            var employee = await _employeeService.GetPersonByIdAsync(id, token);
            return Ok(employee);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees(CancellationToken token)
        {
            var employees = await _employeeService.GetAllPersonsAsync(token);
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDto employeeDto)
        {
            var employee = await _employeeService.AddPersonAsync(employeeDto);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeDto employeeDto)
        {
            var employee = await _employeeService.UpdatePersonAsync(id, employeeDto);
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _employeeService.DeletePersonAsync(id);
            return NoContent();
        }
    }
}