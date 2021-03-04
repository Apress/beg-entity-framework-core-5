using System;
using System.Collections.Generic;
using System.Linq;
using EFCore5WebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;


namespace EFCOre5WebApp.DAL.Tests
{
    [TestFixture]
    public class AggregationTests
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
        public void CountPersons()
        {
            int personCount = _context.Persons.Count();
            Assert.AreEqual(2, personCount);
        }

        [Test]
        public void CountPersonsWithFilter()
        {
            int personCount = _context.Persons.Count(x => x.FirstName == "John" && x.LastName == "Smith");
            Assert.AreEqual(1, personCount);
        }

        [Test]
        public void MinPersonAge()
        {
            var minPersonAge = _context.Persons.Min(x => x.Age);
            Assert.AreEqual(20, minPersonAge);
        }

        [Test]
        public void AveragePersonAge()
        {
            var average = _context.Persons.Average(x => x.Age);
            Assert.AreEqual(25, average);
        }

        [Test]
        public void SumPersonAge()
        {
            var sumAge = _context.Persons.Sum(x => x.Age);
            Assert.AreEqual(50, sumAge);
        }

        [Test]
        public void GroupAddressesByState()
        {
            var expectedILAddressesCount = _context.Addresses.Where(x => x.State == "IL").Count();
            var expectedCAAddressesCount = _context.Addresses.Where(x => x.State == "CA").Count();

            var groupedAddresses = (from a in _context.Addresses.ToList()
                                   group a by a.State into g
                                   select new { State = g.Key, Addresses = g.Select(x => x) }).ToList();

            Assert.AreEqual(expectedILAddressesCount, groupedAddresses.Single(x => x.State == "IL").Addresses.Count());
            Assert.AreEqual(expectedCAAddressesCount, groupedAddresses.Single(x => x.State == "CA").Addresses.Count());
        }


        [Test]
        public void GroupAddressesByStateCount()
        {
            var expectedILAddressesCount = _context.Addresses.Where(x => x.State == "IL").Count();
            var expectedCAAddressesCount = _context.Addresses.Where(x => x.State == "CA").Count();

            var groupedAddresses = (from a in _context.Addresses
                                    group a by a.State into g
                                    select new { State = g.Key, Count = g.Count() }).ToList();

            Assert.AreEqual(expectedILAddressesCount, groupedAddresses.Single(x => x.State == "IL").Count);
            Assert.AreEqual(expectedCAAddressesCount, groupedAddresses.Single(x => x.State == "CA").Count);
        }

        [Test]
        public void MinAgePerState()
        {
            var expectedIlMinAge = 30;
            var expectedCaMinAge = 20;

            var groupedAddresses = from a in _context.Addresses
                                   select new { State = a.State, Age = a.Person.Age } into stateAge
                                   group stateAge by stateAge.State into g
                                   select new { State = g.Key, MinAge = g.Min(a => a.Age) };

            Assert.AreEqual(expectedIlMinAge, groupedAddresses.Single(x => x.State == "IL").MinAge);
            Assert.AreEqual(expectedCaMinAge, groupedAddresses.Single(x => x.State == "CA").MinAge);
        }

        [Test]
        public void MaxAgePerState()
        {
            var expectedIlMaxAge = 30;
            var expectedCaMaxAge = 20;

            var groupedAddresses = from a in _context.Addresses
                                   select new { State = a.State, Age = a.Person.Age } into stateAge
                                   group stateAge by stateAge.State into g
                                   select new { State = g.Key, MaxAge = g.Max(a => a.Age) };

            Assert.AreEqual(expectedIlMaxAge, groupedAddresses.Single(x => x.State == "IL").MaxAge);
            Assert.AreEqual(expectedCaMaxAge, groupedAddresses.Single(x => x.State == "CA").MaxAge);
        }

        [Test]
        public void AverageAgePerState()
        {
            var expectedIlAge = 30;
            var expectedCaAge = 20;

            var groupedAddresses = from a in _context.Addresses
                                   select new { State = a.State, Age = a.Person.Age } into stateAge
                                   group stateAge by stateAge.State into g
                                   select new { State = g.Key, AverageAge = g.Average(a => a.Age) };

            Assert.AreEqual(expectedIlAge, groupedAddresses.Single(x => x.State == "IL").AverageAge);
            Assert.AreEqual(expectedCaAge, groupedAddresses.Single(x => x.State == "CA").AverageAge);
        }

        [Test]
        public void SumAgePerState()
        {
            var expectedIlAge = 60;
            var expectedCaAge = 20;

            var groupedAddresses = from a in _context.Addresses
                                   select new { State = a.State, Age = a.Person.Age } into stateAge
                                   group stateAge by stateAge.State into g
                                   select new { State = g.Key, SumAge = g.Sum(a => a.Age) };

            Assert.AreEqual(expectedIlAge, groupedAddresses.Single(x => x.State == "IL").SumAge);
            Assert.AreEqual(expectedCaAge, groupedAddresses.Single(x => x.State == "CA").SumAge);
        }
    }
}
