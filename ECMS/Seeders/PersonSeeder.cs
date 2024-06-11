using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Person = ECMS.Models.Person;

namespace ECMS.Seeders
{
    public static class PersonSeeder
    {
        public static List<Person> Seed(ModelBuilder modelBuilder)
        {
            var persons = new List<Person>();
            var personFaker = new Faker<Person>()
                .RuleFor(p => p.Id, f => 0) // Id will be set by the database
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Email, f => f.Internet.Email())
                .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber());

            for (int i = 0; i < 10; i++)
            {
                persons.Add(personFaker.Generate());
            }

            modelBuilder.Entity<Person>().HasData(persons);

            return persons;
        }
    }
}