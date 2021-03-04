using EFCore5WebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace EFCOre5WebApp.DAL.Tests
{
    [TestFixture]
    public class SelectTests
    {
        private AppDbContext _context;

        [SetUp]
        public void SetUp()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EfCore5WebApp;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options);
        }

        [Test]
        public void GetAllPersons()
        {
            IEnumerable<Person> persons = _context.Persons.ToList();
            Assert.AreEqual(2, persons.Count());
        }

        [Test]
        public void PersonsHaveAddresses()
        {
            List<Person> persons = _context.Persons.Include("Addresses").ToList();
            Assert.AreEqual(1, persons[0].Addresses.Count);
            Assert.AreEqual(2, persons[1].Addresses.Count);
        }

        [Test]
        public void HaveLookUpRecords()
        {
            var lookUps = _context.LookUps.ToList();
            var countries = lookUps.Where(x => x.LookUpType == LookUpType.Country).ToList();
            var states = lookUps.Where(x => x.LookUpType == LookUpType.State).ToList();

            Assert.AreEqual(1, countries.Count);
            Assert.AreEqual(51, states.Count);
        }
    }
}
