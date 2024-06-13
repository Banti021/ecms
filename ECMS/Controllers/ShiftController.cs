using ECMS.Models;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShiftController(ShiftService service): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetShifts(CancellationToken token)
    {
        var shifts = await service.GetAllShifts(token);
        return Ok(shifts);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetShift(int id, CancellationToken token)
    {
        var shift = await service.GetShiftById(id, token);
        return Ok(shift);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddShift([FromBody] Shift shift)
    {
        var newShift = await service.AddShiftAsync(shift);
        return Ok(newShift);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateShift(int id, [FromBody] Shift shift)
    {
        var updatedShift = await service.UpdateShiftAsync(id, shift);
        return Ok(updatedShift);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShift(int id)
    {
        await service.DeleteShiftAsync(id);
        return NoContent();
    }
    
    [HttpPost("{shiftId}/employees/{employeeId}")]
    public async Task<IActionResult> AddEmployeeToShift(int shiftId, int employeeId)
    {
        await service.AddEmployeeToShiftAsync(shiftId, employeeId);
        return NoContent();
    }
    
    [HttpDelete("{shiftId}/employees/{employeeId}")]
    public async Task<IActionResult> RemoveEmployeeFromShift(int shiftId, int employeeId)
    {
        await service.RemoveEmployeeFromShiftAsync(shiftId, employeeId);
        return NoContent();
    }
    
    [HttpGet("{shiftId}/employees")]
    public async Task<IActionResult> GetEmployeesForShift(int shiftId)
    {
        var employees = await service.GetEmployeesForShiftAsync(shiftId);
        return Ok(employees);
    }
}