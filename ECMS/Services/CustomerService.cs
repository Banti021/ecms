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
    public class CustomerService : IPersonService
    {
        private readonly ApplicationContext _context;

        public CustomerService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<PersonDto> GetPersonByIdAsync(int id, CancellationToken token)
        {
            var customer = await _context.Customers.Include(c => c.Person).FirstOrDefaultAsync(c => c.Id == id, token);
            if (customer == null) throw new Exception("Customer not found");
            return new CustomerDto
            {
                Id = customer.Person.Id,
                FirstName = customer.Person.FirstName,
                LastName = customer.Person.LastName,
                Email = customer.Person.Email,
                PhoneNumber = customer.Person.PhoneNumber,
                DateOfBirth = customer.DateOfBirth,
                JoinDate = customer.JoinDate,
                LastVisit = customer.LastVisit
            };
        }

        public async Task<List<PersonDto>> GetAllPersonsAsync(CancellationToken token)
        {
            var employees = await _context.Employees.Include(e => e.Person).Select(employee => new EmployeeDto
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
            }).ToListAsync(token);

            return employees.Cast<PersonDto>().ToList();
        }

        public async Task<PersonDto> AddPersonAsync(PersonDto personDto)
        {
            var customerDto = personDto as CustomerDto;
            if (customerDto == null) throw new Exception("Invalid DTO type");

            var person = new Person
            {
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Email = customerDto.Email,
                PhoneNumber = customerDto.PhoneNumber
            };
            var customer = new Customer
            {
                Person = person,
                DateOfBirth = customerDto.DateOfBirth,
                JoinDate = customerDto.JoinDate,
                LastVisit = customerDto.LastVisit
            };
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            customerDto.Id = customer.Id;
            return customerDto;
        }

        public async Task<PersonDto> UpdatePersonAsync(int id, PersonDto personDto)
        {
            var customerDto = personDto as CustomerDto;
            if (customerDto == null) throw new Exception("Invalid DTO type");

            var customer = await _context.Customers.Include(c => c.Person).FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null) throw new Exception("Customer not found");

            customer.Person.FirstName = customerDto.FirstName;
            customer.Person.LastName = customerDto.LastName;
            customer.Person.Email = customerDto.Email;
            customer.Person.PhoneNumber = customerDto.PhoneNumber;
            customer.DateOfBirth = customerDto.DateOfBirth;
            customer.JoinDate = customerDto.JoinDate;
            customer.LastVisit = customerDto.LastVisit;

            await _context.SaveChangesAsync();
            return customerDto;
        }

        public async Task DeletePersonAsync(int id)
        {
            var customer = await _context.Customers.Include(c => c.Person).FirstOrDefaultAsync(c => c.Id == id);
            if (customer == null) throw new Exception("Customer not found");

            _context.Customers.Remove(customer);
            _context.Persons.Remove(customer.Person);
            await _context.SaveChangesAsync();
        }
    }
}
