using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Seeders
{
    public static class DepartmentSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var departmentIds = 1;
            var faker = new Faker<Department>()
                .RuleFor(d => d.Id, f => departmentIds++)
                .RuleFor(d => d.Name, f => f.Commerce.Department())
                .RuleFor(d => d.Description, f => f.Lorem.Sentence())
                .RuleFor(d => d.EmployeeCount, f => f.Random.Int(5, 50));

            var departments = faker.Generate(10);

            modelBuilder.Entity<Department>().HasData(departments);
        }
    }
}