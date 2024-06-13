using ECMS.Context;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class ShiftService(ApplicationContext context)
{ 
    public async Task<Shift> GetShiftById(int id, CancellationToken token)
    {
        return await context.Shifts.FindAsync(new object[] { id }, token);
    }
    
    public async Task<List<Shift>> GetAllShifts(CancellationToken token)
    {
        return await context.Shifts.ToListAsync(token);
    }
    
    public async Task<Shift> AddShiftAsync(Shift shift)
    {
        var newShift = await context.Shifts.AddAsync(shift);
        await context.SaveChangesAsync();
        return newShift.Entity;
    }
    
    public async Task<Shift> UpdateShiftAsync(int id, Shift shift)
    {
        var existingShift = await context.Shifts.FindAsync(new object[] { id });
        if (existingShift == null) throw new Exception("Shift not found");
        
        existingShift.ShiftType = shift.ShiftType;
        existingShift.FromHour = shift.FromHour;
        existingShift.ToHour = shift.ToHour;
        
        await context.SaveChangesAsync();
        return existingShift;
    }
    
    public async Task DeleteShiftAsync(int id)
    {
        var shift = await context.Shifts.FindAsync(new object[] { id });
        if (shift == null) throw new Exception("Shift not found");
        
        context.Shifts.Remove(shift);
        await context.SaveChangesAsync();
    }
    
    public async Task AddEmployeeToShiftAsync(int shiftId, int employeeId)
    {
        var shift = await context.Shifts.FindAsync(new object[] { shiftId });
        if (shift == null) throw new Exception("Shift not found");
        
        var employee = await context.Employees.FindAsync(new object[] { employeeId });
        if (employee == null) throw new Exception("Employee not found");
        
        shift.Employees.Add(employee);
        await context.SaveChangesAsync();
    }
    
    public async Task RemoveEmployeeFromShiftAsync(int shiftId, int employeeId)
    {
        var shift = await context.Shifts.FindAsync(new object[] { shiftId });
        if (shift == null) throw new Exception("Shift not found");
        
        var employee = await context.Employees.FindAsync(new object[] { employeeId });
        if (employee == null) throw new Exception("Employee not found");
        
        shift.Employees.Remove(employee);
        await context.SaveChangesAsync();
    }
    
    public async Task<List<Employee>> GetEmployeesForShiftAsync(int shiftId)
    {
        var shift = await context.Shifts.FindAsync(new object[] { shiftId });
        if (shift == null) throw new Exception("Shift not found");
        
        return shift.Employees.ToList();
    }
}