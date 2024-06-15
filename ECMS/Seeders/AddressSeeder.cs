using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using Bogus;

namespace ECMS.Seeders
{
    public static class AddressSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var faker = new Faker();
            var addresses = new List<Address>();

            for (int i = 1; i <= 10; i++)
            {
                addresses.Add(new Address
                {
                    Id = i,
                    City = faker.Address.City(),
                    Street = faker.Address.StreetName(),
                    BuildingNo = faker.Address.BuildingNumber()
                });
            }

            modelBuilder.Entity<Address>().HasData(addresses);
        }
    }
}