using Bogus;
using ECMS.Enums;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Seeders
{
    public static class ShiftSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var shiftIds = 1;
            var faker = new Faker<Shift>()
                .RuleFor(s => s.Id, f => shiftIds++)
                .RuleFor(s => s.ShiftType, f => f.PickRandom<ShiftType>())
                .RuleFor(s => s.FromHour, f => f.Date.Past())
                .RuleFor(s => s.ToHour, f => f.Date.Future());

            var shifts = faker.Generate(10);

            modelBuilder.Entity<Shift>().HasData(shifts);
        }
    }
}