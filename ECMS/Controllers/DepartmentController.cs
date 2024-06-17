using ECMS.DTO;
using ECMS.DTO.Department;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(DepartmentService departmentService): ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDepartments(CancellationToken token)
        {
            var departments = await departmentService.GetAllDepartmentsAsync(token);
            return Ok(departments);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(int id, CancellationToken token)
        {
            var department = await departmentService.GetDepartmentByIdAsync(id, token);
            return Ok(department);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddDepartment([FromBody] DepartmentDto departamentDto)
        {
            var department = await departmentService.AddDepartmentAsync(departamentDto);
            return Ok(department);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] DepartmentDto departamentDto)
        {
            var department = await departmentService.UpdateDepartmentAsync(id, departamentDto);
            return Ok(department);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            await departmentService.DeleteDepartmentAsync(id);
            return NoContent();
        }
        
        [HttpGet("{id}/employees")]
        public async Task<IActionResult> GetDepartmentEmployees(int id, CancellationToken token)
        {
            var employees = await departmentService.GetEmployeesByDepartmentIdAsync(id, token);
            return Ok(employees);
        }
        
        [HttpPost("{id}/add-employee")]
        public async Task<IActionResult> AddDepartmentEmployee(int id, [FromBody] EmployeeDepartmentDto employeeDepartmentDto)
        {
            var message = await departmentService.AssignEmployeeToDepartmentAsync(id, employeeDepartmentDto);
            return Ok(new { message });
        }

        [HttpDelete("{id}/remove-employee")]
        public async Task<IActionResult> RemoveDepartmentEmployee([FromBody] EmployeeDepartmentDto employeeDepartmentDto)
        {
            var message = await departmentService.RemoveEmployeeFromDepartmentAsync(employeeDepartmentDto);
            return Ok(new { message });
        }
    }
}

