using System;
using System.Threading.Tasks;
using ECMS.Context;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services
{
    public class PersonService(ApplicationContext context)
    {
        public async Task<Employee> ConvertCustomerToEmployee(int customerId, string position, decimal salary, DateOnly hireDate, int shiftId, int areaId, int? supervisorId = null, int? departmentId = null)
        {
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var customer = await context.Customers.Include(c => c.Person).FirstOrDefaultAsync(c => c.Id == customerId);
                if (customer == null)
                {
                    throw new Exception("Customer not found");
                }

                var person = customer.Person;

                var employee = new Employee
                {
                    PersonId = person.Id,
                    Position = position,
                    Salary = salary,
                    HireDate = hireDate,
                    ShiftId = shiftId,
                    AreaId = areaId,
                    SupervisorId = supervisorId,
                    DepartmentId = departmentId,
                    Person = person
                };

                context.Customers.Remove(customer);
                context.Employees.Add(employee);

                await context.SaveChangesAsync();
                await transaction.CommitAsync();

                return employee;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<Customer> ConvertEmployeeToCustomer(int employeeId, DateTime dateOfBirth, DateTime joinDate, DateTime lastVisit)
        {
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                var employee = await context.Employees.Include(e => e.Person).FirstOrDefaultAsync(e => e.Id == employeeId);
                if (employee == null)
                {
                    throw new Exception("Employee not found");
                }

                var person = employee.Person;

                var customer = new Customer
                {
                    PersonId = person.Id,
                    DateOfBirth = dateOfBirth,
                    JoinDate = joinDate,
                    LastVisit = lastVisit,
                    Person = person
                };

                context.Employees.Remove(employee);
                context.Customers.Add(customer);

                await context.SaveChangesAsync();
                await transaction.CommitAsync();

                return customer;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
