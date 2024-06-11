using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Seeders
{
    public static class AreaSeeder
    {
        public static List<Area> Seed(ModelBuilder modelBuilder, List<Facility> facilities)
        {
            var areas = new List<Area>();
            
            var fakeAreas = new Faker<Area>()
                .RuleFor(a => a.Id, f => 0) // Id will be set by the database
                .RuleFor(a => a.Name, f => f.Commerce.Department())
                .RuleFor(a => a.FacilityId, f => f.PickRandom(facilities).Id)
                .RuleFor(a => a.Description, f => f.Lorem.Sentence())
                .RuleFor(a => a.Capacity, f => f.Random.Number(1, 1000));

            for (int i = 0; i < 10; i++)
            {
                areas.Add(fakeAreas.Generate());
            }
            
            modelBuilder.Entity<Area>().HasData(areas);

            return areas;
        }
    }
}

