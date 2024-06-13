using ECMS.Context;
using ECMS.DTO;
using ECMS.Interfaces;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECMS.Services
{
    public class EmployeeService : IPersonService
    {
        private readonly ApplicationContext _context;

        public EmployeeService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<PersonDto> GetPersonByIdAsync(int id, CancellationToken token)
        {
            var employee = await _context.Employees.Include(e => e.Person).FirstOrDefaultAsync(e => e.Id == id, token);
            if (employee == null) throw new Exception("Employee not found");
            return new EmployeeDto
            {
                Id = employee.Person.Id,
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
            };
        }

        public async Task<List<PersonDto>> GetAllPersonsAsync(CancellationToken token)
        {
            var customers = await _context.Customers.Include(c => c.Person).Select(customer => new CustomerDto
            {
                Id = customer.Person.Id,
                FirstName = customer.Person.FirstName,
                LastName = customer.Person.LastName,
                Email = customer.Person.Email,
                PhoneNumber = customer.Person.PhoneNumber,
                DateOfBirth = customer.DateOfBirth,
                JoinDate = customer.JoinDate,
                LastVisit = customer.LastVisit
            }).ToListAsync(token);

            return customers.Cast<PersonDto>().ToList();
        }

        public async Task<PersonDto> AddPersonAsync(PersonDto personDto)
        {
            var employeeDto = personDto as EmployeeDto;
            if (employeeDto == null) throw new Exception("Invalid DTO type");

            var person = new Person
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Email = employeeDto.Email,
                PhoneNumber = employeeDto.PhoneNumber
            };
            var employee = new Employee
            {
                Person = person,
                Position = employeeDto.Position,
                Salary = employeeDto.Salary,
                HireDate = employeeDto.HireDate,
                SupervisorId = employeeDto.SupervisorId,
                DepartmentId = employeeDto.DepartmentId,
                ShiftId = employeeDto.ShiftId,
                AreaId = employeeDto.AreaId
            };
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            employeeDto.Id = employee.Id;
            return employeeDto;
        }

        public async Task<PersonDto> UpdatePersonAsync(int id, PersonDto personDto)
        {
            var employeeDto = personDto as EmployeeDto;
            if (employeeDto == null) throw new Exception("Invalid DTO type");

            var employee = await _context.Employees.Include(e => e.Person).FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null) throw new Exception("Employee not found");

            employee.Person.FirstName = employeeDto.FirstName;
            employee.Person.LastName = employeeDto.LastName;
            employee.Person.Email = employeeDto.Email;
            employee.Person.PhoneNumber = employeeDto.PhoneNumber;
            employee.Position = employeeDto.Position;
            employee.Salary = employeeDto.Salary;
            employee.HireDate = employeeDto.HireDate;
            employee.SupervisorId = employeeDto.SupervisorId;
            employee.DepartmentId = employeeDto.DepartmentId;
            employee.ShiftId = employeeDto.ShiftId;
            employee.AreaId = employeeDto.AreaId;

            await _context.SaveChangesAsync();
            return employeeDto;
        }

        public async Task DeletePersonAsync(int id)
        {
            var employee = await _context.Employees.Include(e => e.Person).FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null) throw new Exception("Employee not found");

            _context.Employees.Remove(employee);
            _context.Persons.Remove(employee.Person);
            await _context.SaveChangesAsync();
        }
    }
}
