using Microsoft.EntityFrameworkCore;
using ECMS.Models;
using Bogus;
using System.Collections.Generic;
using Person = ECMS.Models.Person;

namespace ECMS.Seeders
{
    public static class PersonSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var faker = new Faker();
            var persons = new List<Person>();

            for (int i = 1; i <= 50; i++) // Increased to 50 to ensure we have enough persons
            {
                persons.Add(new Person
                {
                    Id = i,
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    Email = faker.Internet.Email(),
                    PhoneNumber = faker.Phone.PhoneNumber()
                });
            }

            modelBuilder.Entity<Person>().HasData(persons);
        }
    }
}