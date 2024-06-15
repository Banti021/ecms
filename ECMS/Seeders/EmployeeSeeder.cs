using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECMS.Seeders
{
    public static class EmployeeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            int employeeIds = -1;
            var faker = new Faker<Employee>()
                .RuleFor(e => e.Id, f => employeeIds--)
                .RuleFor(e => e.PersonId, f => f.IndexFaker + 31) // Ensuring PersonId is unique and in the correct range
                .RuleFor(e => e.Position, f => f.Name.JobTitle())
                .RuleFor(e => e.Salary, f => f.Finance.Amount(30000, 100000))
                .RuleFor(e => e.HireDate, f => DateOnly.FromDateTime(f.Date.Past()))
                .RuleFor(e => e.ShiftId, f => f.Random.Int(1, 10))
                .RuleFor(e => e.AreaId, f => f.Random.Int(1, 50))
                .RuleFor(e => e.DepartmentId, f => f.Random.Int(1, 10))
                .RuleFor(e => e.SupervisorId, f => (int?)null); // No SupervisorId initially

            var employees = faker.Generate(20);

            // Assign supervisors deterministically
            var supervisorCandidates = employees.Take(10).ToList();
            for (int i = 10; i < employees.Count; i++)
            {
                employees[i].SupervisorId = supervisorCandidates[i % supervisorCandidates.Count].Id;
            }

            modelBuilder.Entity<Employee>().HasData(employees);
        }
    }
}