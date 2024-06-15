using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using Bogus;

namespace ECMS.Seeders
{
    public static class CustomerSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var faker = new Faker();
            var customers = new List<Customer>();

            for (int i = 1; i <= 10; i++)
            {
                customers.Add(new Customer
                {
                    Id = i,
                    PersonId = i,
                    DateOfBirth = DateOnly.FromDateTime(faker.Date.Past(30, DateTime.Now.AddYears(-18))),
                    JoinDate = DateOnly.FromDateTime(faker.Date.Past(5)),
                    LastVisit = DateOnly.FromDateTime(faker.Date.Recent(30))
                });
            }

            modelBuilder.Entity<Customer>().HasData(customers);
        }
    }
}