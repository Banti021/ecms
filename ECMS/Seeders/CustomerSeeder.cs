using Bogus;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Person = ECMS.Models.Person;

namespace ECMS.Seeders
{
    public static class CustomerSeeder
    {
        public static List<Customer> Seed(ModelBuilder modelBuilder, List<Person> persons)
        {
            var customers = new List<Customer>();
            var customerFaker = new Faker<Customer>()
                .RuleFor(c => c.Id, f => 0) // Id will be set by the database
                .RuleFor(c => c.PersonId, f => f.PickRandom(persons).Id)
                .RuleFor(c => c.DateOfBirth, f => DateOnly.FromDateTime(f.Date.Past(30)))
                .RuleFor(c => c.JoinDate, f => DateOnly.FromDateTime(f.Date.Past(10)))
                .RuleFor(c => c.LastVisit, f => DateOnly.FromDateTime(f.Date.Recent()));

            for (int i = 0; i < 10; i++)
            {
                customers.Add(customerFaker.Generate());
            }

            modelBuilder.Entity<Customer>().HasData(customers);

            return customers;
        }
    }
}