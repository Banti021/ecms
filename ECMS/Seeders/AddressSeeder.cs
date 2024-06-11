using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Seeders
{
    public static class AddressSeeder
    {
        public static List<Address> Seed(ModelBuilder modelBuilder)
        {
            var addresses = new List<Address>();

            var fakeAddress = new Faker<Address>()
                .RuleFor(a => a.City, f => f.Address.City())
                .RuleFor(a => a.Street, f => f.Address.StreetName())
                .RuleFor(a => a.BuildingNo, f => f.Address.BuildingNumber());
                
            for (int i = 0; i < 10; i++)
            {
                addresses.Add(fakeAddress.Generate());
            }
            
            modelBuilder.Entity<Address>().HasData(addresses);

            return addresses;
        }
    }
}

