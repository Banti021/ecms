using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using Bogus;

namespace ECMS.Seeders
{
    public static class FacilitySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var faker = new Faker();
            var facilities = new List<Facility>();

            for (int i = 1; i <= 10; i++)
            {
                facilities.Add(new Facility
                {
                    Id = i,
                    Name = faker.Company.CompanyName(),
                    AddressId = i,
                    Description = faker.Lorem.Sentence(),
                    Capacity = faker.Random.Int(100, 500)
                });
            }

            modelBuilder.Entity<Facility>().HasData(facilities);
        }
    }
}