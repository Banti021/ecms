using ECMS.DTO;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(DepartmentService departamentService): ControllerBase
    {
        private readonly DepartmentService _departamentService = departamentService;
        
        [HttpGet]
        public async Task<IActionResult> GetDepartments(CancellationToken token)
        {
            var departments = await _departamentService.GetAllDepartmentsAsync(token);
            return Ok(departments);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(int id, CancellationToken token)
        {
            var department = await _departamentService.GetDepartmentByIdAsync(id, token);
            return Ok(department);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddDepartment([FromBody] DepartmentDto departamentDto)
        {
            var department = await _departamentService.AddDepartmentAsync(departamentDto);
            return Ok(department);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] DepartmentDto departamentDto)
        {
            var department = await _departamentService.UpdateDepartmentAsync(id, departamentDto);
            return Ok(department);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            await _departamentService.DeleteDepartmentAsync(id);
            return NoContent();
        }
    }
}

