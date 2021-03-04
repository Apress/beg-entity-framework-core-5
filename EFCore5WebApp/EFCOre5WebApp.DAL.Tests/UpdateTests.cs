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
            person.FirstName = "Matt";
            person.LastName = "Smith";
            person.EmailAddress = "doctor@who.com";
            var address = person.Addresses.First();
            address.AddressLine1 = "123 Update St";
            address.AddressLine2 = "APT B1";
            address.City = "Okemos";
            address.State = "MI";
            address.Country = "USA";
            address.ZipCode = "48864";
            _context.SaveChanges();

            var updatedPerson = _context.Persons.Single(x => x.Id == _personId);
            Assert.AreEqual(1, updatedPerson.Addresses.Count);
            Assert.AreEqual("Matt", updatedPerson.FirstName);
            Assert.AreEqual("Smith", updatedPerson.LastName);
            Assert.AreEqual("doctor@who.com", updatedPerson.EmailAddress);
            var updatedAddress = updatedPerson.Addresses.First();
            Assert.AreEqual("123 Update St", updatedAddress.AddressLine1);
            Assert.AreEqual("APT B1", updatedAddress.AddressLine2);
            Assert.AreEqual("Okemos", updatedAddress.City);
            Assert.AreEqual("MI", updatedAddress.State);
            Assert.AreEqual("48864", updatedAddress.ZipCode);
            Assert.AreEqual("USA", updatedAddress.Country);
        }

        [TearDown]
        public void TearDown()
        {
            var person = _context.Persons.Single(x => x.Id == _personId);
            person.Addresses.Clear();
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }
    }
}
