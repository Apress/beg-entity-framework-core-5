using System;
using System.Collections.Generic;
using System.Linq;
using EFCore5WebApp.Core.Entities;
using EFCOre5WebApp.DAL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace EFCore5WebApp.DAL.Tests
{
    [TestFixture]
    public class DeleteTests
    {
        private AppDbContext _context;

        [SetUp]
        public void SetUp()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
               .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EfCore5WebApp;Trusted_Connection=True;MultipleActiveResultSets=true")
               .Options);

            // add person record
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
                    new Address
                    {
                        AddressLine1 = "555 Waverly Street",
                        AddressLine2 = "APT B2",
                        City = "Mt. Pleasant",
                        State = "MI",
                        ZipCode = "48858",
                        Country = "USA"
                    }
                }
            };

            _context.Persons.Add(record);

            _context.SaveChanges();
        }

        [Test]
        public void DeletePerson()
        {
            var existing = _context.Persons.Single(x => x.FirstName == "Clarke" && x.LastName == "Kent");
            var personId = existing.Id;
            _context.Persons.Remove(existing);
            _context.SaveChanges();
            var found = _context.Persons.SingleOrDefault(x => x.FirstName == "Clarke" && x.LastName == "Kent");
            Assert.IsNull(found);
            var addresses = _context.Addresses.Where(x => x.PersonId == personId);
            Assert.AreEqual(0, addresses.Count());
        }
    }
}
