using EFCore5WebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCOre5WebApp.DAL.Tests
{
    [TestFixture]
    public class StoredProceduresTests
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
        public void GetPersonsByStateInterpolated()
        {
            string state = "IL";
            var persons = _context.Persons.FromSqlInterpolated($"GetPersonsByState {state}").ToList();
            Assert.AreEqual(2, persons.Count);
        }

        [Test]
        public void GetPersonsByStateRaw()
        {
            string state = "IL";
            var persons = _context.Persons.FromSqlRaw($"GetPersonsByState @p0", new[] { state }).ToList();
            Assert.AreEqual(2, persons.Count);
        }

        [Test]
        public void AddLookUpItemInterpolated()
        {
            string code = "CAN";
            string description = "Canada";
            LookUpType lookUpType = LookUpType.Country;
            _context.Database.ExecuteSqlInterpolated($"AddLookUpItem {code}, {description}, {lookUpType}");

            var addedItem = _context.LookUps.Single(x => x.Code == "CAN");
            Assert.IsNotNull(addedItem);

            _context.LookUps.Remove(addedItem);
            _context.SaveChanges();
        }

        [Test]
        public void AddLookUpItemRaw()
        {
            string code = "MEX";
            string description = "Mexico";
            LookUpType lookUpType = LookUpType.Country;
            _context.Database.ExecuteSqlRaw("AddLookUpItem @p0,@p1,@p2", new object[] { code, description, lookUpType });

            var addedItem = _context.LookUps.Single(x => x.Code == "MEX");
            Assert.IsNotNull(addedItem);

            _context.LookUps.Remove(addedItem);
            _context.SaveChanges();
        }

    }
}
