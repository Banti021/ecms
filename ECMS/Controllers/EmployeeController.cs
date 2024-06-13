using ECMS.DTO;
using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController(EmployeeService employeeService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id, CancellationToken token)
        {
            var employee = await employeeService.GetPersonByIdAsync(id, token);
            return Ok(employee);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees(CancellationToken token)
        {
            var employees = await employeeService.GetAllPersonsAsync(token);
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDto employeeDto)
        {
            var employee = await employeeService.AddPersonAsync(employeeDto);
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeDto employeeDto)
        {
            var employee = await employeeService.UpdatePersonAsync(id, employeeDto);
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await employeeService.DeletePersonAsync(id);
            return NoContent();
        }
    }
}