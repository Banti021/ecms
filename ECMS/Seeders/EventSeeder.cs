using Bogus;
using ECMS.Enums;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Seeders
{
    public static class EventSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            int eventIds = -1;
            var faker = new Faker<Event>()
                .RuleFor(e => e.Id, f => eventIds--)
                .RuleFor(e => e.Title, f => Truncate(f.Lorem.Sentence(), 100))
                .RuleFor(e => e.Description, f => Truncate(f.Lorem.Paragraph(), 255))
                .RuleFor(e => e.EventCategory, f => f.PickRandom<EventCategory>())
                .RuleFor(e => e.RegularPrice, f => f.Random.Decimal(10, 1000))
                .RuleFor(e => e.VipPrice, (f, e) => e.RegularPrice * 1.5m)
                .RuleFor(e => e.StartTime, f => f.Date.Future())
                .RuleFor(e => e.EndTime, (f, e) => e.StartTime.AddHours(f.Random.Double(1, 4)))
                .RuleFor(e => e.MaxAttendees, f => f.Random.Int(50, 200))
                .RuleFor(e => e.CurrentAttendees, f => f.Random.Int(0, 50));

            var events = faker.Generate(20);

            builder.Entity<Event>().HasData(events);
        }

        private static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}