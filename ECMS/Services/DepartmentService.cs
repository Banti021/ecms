using ECMS.Context;
using ECMS.DTO;
using ECMS.DTO.Department;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services;

public class DepartmentService(ApplicationContext context)
{
    private readonly ApplicationContext _context = context;
    
    public async Task<List<DepartmentDto>> GetAllDepartmentsAsync(CancellationToken token)
    {
        var departments = await _context.Departments.Select(department => new DepartmentDto
        {
            Id = department.Id,
            Name = department.Name,
            Description = department.Description,
            EmployeeCount = department.Employees.Count
        }).ToListAsync(token);
        
        return departments;
    }
    
    public async Task<DepartmentDto> GetDepartmentByIdAsync(int id, CancellationToken token)
    {
        var department = await _context.Departments.Include(d => d.Employees).FirstOrDefaultAsync(d => d.Id == id, token);
        if (department == null) throw new Exception("Department not found");
        return new DepartmentDto
        {
            Id = department.Id,
            Name = department.Name,
            Description = department.Description,
            EmployeeCount = department.Employees.Count
        };
    }
    
    public async Task<DepartmentDto> AddDepartmentAsync(DepartmentDto departmentDto)
    {
        var department = new Department
        {
            Name = departmentDto.Name,
            Description = departmentDto.Description
        };
        
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
        
        return new DepartmentDto
        {
            Name = department.Name,
            Description = department.Description,
            EmployeeCount = department.Employees.Count
        };
    }
    
    public async Task<DepartmentDto> UpdateDepartmentAsync(int id, DepartmentDto departmentDto)
    {
        var department = await _context.Departments.FindAsync(id);
        if (department == null) throw new Exception("Department not found");
        
        department.Name = departmentDto.Name;
        department.Description = departmentDto.Description;
        
        await _context.SaveChangesAsync();
        
        return new DepartmentDto
        {
            Name = department.Name,
            Description = department.Description,
            EmployeeCount = department.Employees.Count
        };
    }
    
    public async Task DeleteDepartmentAsync(int id)
    {
        var department = await _context.Departments.FindAsync(id);
        if (department == null) throw new Exception("Department not found");
        
        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();
    }
    
    public async Task<List<EmployeeDto>> GetEmployeesByDepartmentIdAsync(int departmentId, CancellationToken token)
    {
        var department = await _context.Departments.Include(d => d.Employees).FirstOrDefaultAsync(d => d.Id == departmentId, token);
        if (department == null) throw new Exception("Department not found");
        
        var employees = department.Employees.Select(employee => new EmployeeDto
        {
            FirstName = employee.Person.FirstName,
            LastName = employee.Person.LastName,
            Email = employee.Person.Email,
            PhoneNumber = employee.Person.PhoneNumber,
            Position = employee.Position,
            Salary = employee.Salary,
            HireDate = employee.HireDate,
            SupervisorId = employee.SupervisorId,
            DepartmentId = employee.DepartmentId,
            ShiftId = employee.ShiftId,
            AreaId = employee.AreaId
        }).ToList();
        
        return employees;
    }
    
    public async Task<string> AssignEmployeeToDepartmentAsync(int departmentId, EmployeeDepartmentDto employeeDepartmentDto)
    {
        var employee = await _context.Employees.FindAsync(employeeDepartmentDto.EmployeeId);
        if (employee == null) throw new Exception("Employee not found");

        var department = await _context.Departments.FindAsync(departmentId);
        if (department == null) throw new Exception("Department not found");

        employee.DepartmentId = departmentId;
        await _context.SaveChangesAsync();

        return "Employee successfully assigned to department";
    }

    public async Task<string> RemoveEmployeeFromDepartmentAsync(EmployeeDepartmentDto employeeDepartmentDto)
    {
        var employee = await _context.Employees.FindAsync(employeeDepartmentDto.EmployeeId);
        if (employee == null) throw new Exception("Employee not found");

        employee.DepartmentId = null;
        await _context.SaveChangesAsync();

        return "Employee successfully removed from department";
    }
}