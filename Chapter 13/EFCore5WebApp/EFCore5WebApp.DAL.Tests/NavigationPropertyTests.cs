using EFCore5WebApp.Core.Entities;
using EFCOre5WebApp.DAL;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace EFCore5WebApp.DAL.Tests
{
    [TestFixture]
    public class NavigationPropertyTests
    {
        private AppDbContext _context;
        private Person _person;

        [SetUp]
        public void SetUp()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EfCore5WebApp;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options);

            _person = new Person()
            {
                FirstName = "Clarke",
                LastName = "Kent",
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

            _context.Persons.Add(_person);

            _context.SaveChanges();
        }

        [Test]
        public void GetAddressesFromPerson()
        {
            Assert.AreEqual(2, _person.Addresses.Count);
        }

        [Test]
        public void GetPersonFromAddress()
        {
            var address = _person.Addresses.First();
            Assert.IsNotNull(address.Person);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Persons.Remove(_person);
            _context.SaveChanges();
        }
    }
}
