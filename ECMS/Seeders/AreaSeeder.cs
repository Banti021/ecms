using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using Bogus;

namespace ECMS.Seeders
{
    public static class AreaSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var faker = new Faker();
            var areas = new List<Area>();
            
            int areaId = 1;
            for (int facilityId = 1; facilityId <= 10; facilityId++)
            {
                for (int i = 0; i < 5; i++) 
                {
                    areas.Add(new Area
                    {
                        Id = areaId++,
                        Name = faker.Company.CatchPhrase(),
                        Capacity = faker.Random.Int(50, 200),
                        Description = faker.Lorem.Sentence(),
                        IsAvailable = faker.Random.Bool(),
                        FacilityId = facilityId
                    });
                }
            }

            modelBuilder.Entity<Area>().HasData(areas);
        }
    }
}