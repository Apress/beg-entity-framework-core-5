using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace EFCOre5WebApp.DAL.Tests
{
    [TestFixture]
    public class NavigationPropertyTests
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
        public void GetAddressesFromPerson()
        {
            var person = _context.Persons.Include("Addresses").Single(x => x.Id == 1);
            Assert.AreEqual(1, person.Addresses.Count);
        }

        [Test]
        public void GetPersonFromAddress()
        {
            var address = _context.Addresses.Include("Person").Single(x => x.Id == 1);
            Assert.IsNotNull(address.Person);
        }
    }
}
