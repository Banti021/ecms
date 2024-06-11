using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Seeders
{
    public static class FacilitySeeder
    {
        public static List<Facility> Seed(ModelBuilder modelBuilder, List<Address> addresses)
        {
            var facilities = new List<Facility>();
            
            var fakeFacilities = new Faker<Facility>()
                .RuleFor(fa => fa.Id, f => 0) // Id will be set by the database
                .RuleFor(fa => fa.Name, f => f.Company.CompanyName())
                .RuleFor(fa => fa.AddressId, f => f.PickRandom(addresses).Id)
                .RuleFor(fa => fa.Description, f => f.Lorem.Sentence())
                .RuleFor(fa => fa.Capacity, f => f.Random.Number(1, 1000));

            for (int i = 0; i < 10; i++)
            {
                facilities.Add(fakeFacilities.Generate());
            }
            
            modelBuilder.Entity<Facility>().HasData(facilities);

            return facilities;
        }
    }
}

