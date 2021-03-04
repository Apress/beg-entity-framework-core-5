using System;
using System.Collections.Generic;
using System.Linq;
using EFCore5WebApp.Core.Entities;

using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace EFCOre5WebApp.DAL.Tests
{
    [TestFixture]
    public class UpdateTests
    {
        private AppDbContext _context;
        private int _personId;

        [SetUp]
        public void SetUp()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
               .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EfCore5WebApp;Trusted_Connection=True;MultipleActiveResultSets=true")
               .Options);

            var record = new Person()
            {
                FirstName = "Clarke",
                LastName = "Kent",
                CreatedOn = DateTime.Now,
                EmailAddress = "clark@daileybugel.com",
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressLine1 = "1234 Fake Street",
                        AddressLine2 = "Suite 1",
                        City = "Chicago",
                        State = "IL",
                        ZipCode = "60652",
                        Country = "United States"
                    },
                }
            };

            _context.Persons.Add(record);

            _context.SaveChanges();

            _personId = record.Id;
        }

        [Test]
        public void UpdatePersonWithAddresses()
        {
            var person = _context.Persons.Single(x => x.Id == _personId);
            string firstName = "Matt";
            string lastName = "Smith";
            string email = "doctor@who.com";
            person.FirstName = firstName;
            person.LastName = lastName;
            person.EmailAddress = email;
            var address = person.Addresses.First();
            string addressLine1 = "123 Update St";
            string addressLine2 = "APT B1";
            string city = "Okemos";
            string state = "MI";
            string country = "USA";
            string zipCode = "48864";
            address.AddressLine1 = addressLine1;
            address.AddressLine2 = addressLine2;
            address.City = city;
            address.State = state;
            address.Country = country;
            address.ZipCode = zipCode;
            _context.SaveChanges();

            var updatedPerson = _context.Persons.Single(x => x.Id == _personId);
            Assert.AreEqual(1, updatedPerson.Addresses.Count);
            Assert.AreEqual(firstName, updatedPerson.FirstName);
            Assert.AreEqual(lastName, updatedPerson.LastName);
            Assert.AreEqual(email, updatedPerson.EmailAddress);
            var updatedAddress = updatedPerson.Addresses.First();
            Assert.AreEqual(addressLine1, updatedAddress.AddressLine1);
            Assert.AreEqual(addressLine2, updatedAddress.AddressLine2);
            Assert.AreEqual(city, updatedAddress.City);
            Assert.AreEqual(state, updatedAddress.State);
            Assert.AreEqual(zipCode, updatedAddress.ZipCode);
            Assert.AreEqual(country, updatedAddress.Country);
        }

        [TearDown]
        public void TearDown()
        {
            var person = _context.Persons.Single(x => x.Id == _personId);
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }
    }
}
