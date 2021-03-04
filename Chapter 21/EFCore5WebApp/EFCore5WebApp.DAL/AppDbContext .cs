using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using EFCore5WebApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EFCOre5WebApp.DAL
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<LookUp> LookUps { get; set; }

        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public IEnumerable<T> GetPagedData<T>(IQueryable<T> data, int pageSize, int page)
            where T : class, new()
        {
            return data.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasMany(x => x.Addresses)
               .WithOne(x => x.Person)
               .HasForeignKey(x => x.PersonId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<LookUp>().HasData(new List<LookUp>()
            {
                new LookUp() { Code = "AL", Description = "Alabama", LookUpType = LookUpType.State},
                new LookUp() { Code = "AK", Description = "Alaska", LookUpType = LookUpType.State},
                new LookUp() { Code = "AZ", Description = "Arizona", LookUpType = LookUpType.State},
                new LookUp() { Code = "AR", Description = "Arkansas", LookUpType = LookUpType.State},
                new LookUp() { Code = "CA", Description = "California", LookUpType = LookUpType.State},
                new LookUp() { Code = "CO", Description = "Colorado", LookUpType = LookUpType.State},
                new LookUp() { Code = "CT", Description = "Connecticut", LookUpType = LookUpType.State},
                new LookUp() { Code = "DE", Description = "Delaware", LookUpType = LookUpType.State},
                new LookUp() { Code = "DC", Description = "District of Columbia", LookUpType = LookUpType.State},
                new LookUp() { Code = "FL", Description = "Florida", LookUpType = LookUpType.State},
                new LookUp() { Code = "GA", Description = "Georgia", LookUpType = LookUpType.State},
                new LookUp() { Code = "HI", Description = "Hawaii", LookUpType = LookUpType.State},
                new LookUp() { Code = "ID", Description = "Idaho", LookUpType = LookUpType.State},
                new LookUp() { Code = "IL", Description = "Illinois", LookUpType = LookUpType.State},
                new LookUp() { Code = "IN", Description = "Indiana", LookUpType = LookUpType.State},
                new LookUp() { Code = "IA", Description = "Iowa", LookUpType = LookUpType.State},
                new LookUp() { Code = "KS", Description = "Kansas", LookUpType = LookUpType.State},
                new LookUp() { Code = "KY", Description = "Kentucky", LookUpType = LookUpType.State},
                new LookUp() { Code = "LA", Description = "Louisiana", LookUpType = LookUpType.State},
                new LookUp() { Code = "ME", Description = "Maine", LookUpType = LookUpType.State},
                new LookUp() { Code = "MD", Description = "Maryland", LookUpType = LookUpType.State},
                new LookUp() { Code = "MA", Description = "Massachusetts", LookUpType = LookUpType.State},
                new LookUp() { Code = "MI", Description = "Michigan", LookUpType = LookUpType.State},
                new LookUp() { Code = "MN", Description = "Minnesota", LookUpType = LookUpType.State},
                new LookUp() { Code = "MS", Description = "Mississippi", LookUpType = LookUpType.State},
                new LookUp() { Code = "MO", Description = "Missouri", LookUpType = LookUpType.State},
                new LookUp() { Code = "MT", Description = "Montana", LookUpType = LookUpType.State},
                new LookUp() { Code = "NE", Description = "Nebraska", LookUpType = LookUpType.State},
                new LookUp() { Code = "NV", Description = "Nevada", LookUpType = LookUpType.State},
                new LookUp() { Code = "NH", Description = "New Hampshire", LookUpType = LookUpType.State},
                new LookUp() { Code = "NJ", Description = "New Jersey", LookUpType = LookUpType.State},
                new LookUp() { Code = "NM", Description = "New Mexico", LookUpType = LookUpType.State},
                new LookUp() { Code = "NY", Description = "New York", LookUpType = LookUpType.State},
                new LookUp() { Code = "NC", Description = "New Carolina", LookUpType = LookUpType.State},
                new LookUp() { Code = "ND", Description = "North Dakota", LookUpType = LookUpType.State},
                new LookUp() { Code = "OH", Description = "Ohio", LookUpType = LookUpType.State},
                new LookUp() { Code = "OK", Description = "Oklahoma", LookUpType = LookUpType.State},
                new LookUp() { Code = "OR", Description = "Oregon", LookUpType = LookUpType.State},
                new LookUp() { Code = "PA", Description = "Pennsylvania", LookUpType = LookUpType.State},
                new LookUp() { Code = "RI", Description = "Rhode Island", LookUpType = LookUpType.State},
                new LookUp() { Code = "SC", Description = "South Carolina", LookUpType = LookUpType.State},
                new LookUp() { Code = "SD", Description = "South Dakota", LookUpType = LookUpType.State},
                new LookUp() { Code = "TN", Description = "Tennessee", LookUpType = LookUpType.State},
                new LookUp() { Code = "TX", Description = "Texas", LookUpType = LookUpType.State},
                new LookUp() { Code = "UT", Description = "Utah", LookUpType = LookUpType.State},
                new LookUp() { Code = "VT", Description = "Vermont", LookUpType = LookUpType.State},
                new LookUp() { Code = "VA", Description = "Virginia", LookUpType = LookUpType.State},
                new LookUp() { Code = "WA", Description = "Washington", LookUpType = LookUpType.State},
                new LookUp() { Code = "WV", Description = "West Virginia", LookUpType = LookUpType.State},
                new LookUp() { Code = "WI", Description = "Wisconsis", LookUpType = LookUpType.State},
                new LookUp() { Code = "WY", Description = "Wyoming", LookUpType = LookUpType.State},
                new LookUp() { Code = "PR", Description = "Puerto Rico", LookUpType = LookUpType.State},
                new LookUp() { Code = "USA", Description = "United States of America", LookUpType = LookUpType.Country}
            });

            modelBuilder.Entity<Person>().HasData(new List<Person>()
            {
                new Person(){ Id = 1, FirstName = "John", LastName = "Smith", EmailAddress = "john@smith.com", Age = 20 },
                new Person(){ Id = 2, FirstName = "Susan", LastName = "Jones", EmailAddress = "john@smith.com", Age = 30 },
                new Person(){ Id = 3, FirstName = "Jane", LastName = "Foster", EmailAddress = "john@smith.com", Age = 31 },
                new Person(){ Id = 4, FirstName = "Burt", LastName = "Reynolds", EmailAddress = "john@smith.com", Age = 32 },
                new Person(){ Id = 5, FirstName = "Maisie", LastName = "Williams", EmailAddress = "john@smith.com", Age = 33 },
                new Person(){ Id = 6, FirstName = "Kit", LastName = "Harrington", EmailAddress = "john@smith.com", Age = 34 },
                new Person(){ Id = 7, FirstName = "Sophie", LastName = "Turner", EmailAddress = "john@smith.com", Age = 35 },
                new Person(){ Id = 8, FirstName = "Lena", LastName = "Headey", EmailAddress = "john@smith.com", Age = 36 },
                new Person(){ Id = 9, FirstName = "Peter", LastName = "Dinklage", EmailAddress = "john@smith.com", Age = 37 },
                new Person(){ Id = 10, FirstName = "Nikolaj", LastName = "Coster-Waldau", EmailAddress = "john@smith.com", Age = 38 },
                new Person(){ Id = 11, FirstName = "Gwendoline", LastName = "Christie", EmailAddress = "john@smith.com", Age = 39 },
                new Person(){ Id = 12, FirstName = "Isac", LastName = "Hempstead", EmailAddress = "john@smith.com", Age = 40 },
                new Person(){ Id = 13, FirstName = "Iain", LastName = "Glen", EmailAddress = "john@smith.com", Age = 20 },
                new Person(){ Id = 14, FirstName = "Alfie", LastName = "Allen", EmailAddress = "john@smith.com", Age = 21 },
                new Person(){ Id = 15, FirstName = "Nathalie", LastName = "Emmanuel", EmailAddress = "john@smith.com", Age = 22 },
                new Person(){ Id = 16, FirstName = "Carice", LastName = "van Houten", EmailAddress = "john@smith.com", Age = 23 },
                new Person(){ Id = 17, FirstName = "Conleth", LastName = "Hil", EmailAddress = "john@smith.com", Age = 24 },
                new Person(){ Id = 18, FirstName = "John", LastName = "Bradley", EmailAddress = "john@smith.com", Age = 25 },
                new Person(){ Id = 19, FirstName = "Liam", LastName = "Cunningham", EmailAddress = "john@smith.com", Age = 26 },
                new Person(){ Id = 20, FirstName = "Aidan", LastName = "Gillen", EmailAddress = "john@smith.com", Age = 27 },
                new Person(){ Id = 21, FirstName = "Jason", LastName = "Mamoa", EmailAddress = "john@smith.com", Age = 28 },
                new Person(){ Id = 22, FirstName = "Natalie", LastName = "Dormer", EmailAddress = "john@smith.com", Age = 29 },
                new Person(){ Id = 23, FirstName = "Richard", LastName = "Madden", EmailAddress = "john@smith.com", Age = 30 },
                new Person(){ Id = 24, FirstName = "Rosie", LastName = "Leslie", EmailAddress = "john@smith.com", Age = 31 },
                new Person(){ Id = 25, FirstName = "Jerome", LastName = "Flynn", EmailAddress = "john@smith.com", Age = 32 },
                new Person(){ Id = 26, FirstName = "Kristofer", LastName = "Hivju", EmailAddress = "john@smith.com", Age = 33 },
                new Person(){ Id = 27, FirstName = "Jacob", LastName = "Anderson", EmailAddress = "john@smith.com", Age = 34 },
                new Person(){ Id = 28, FirstName = "Jack", LastName = "Gleeson", EmailAddress = "john@smith.com", Age = 35 },
                new Person(){ Id = 29, FirstName = "Hannah", LastName = "Murray", EmailAddress = "john@smith.com", Age = 36 },
                new Person(){ Id = 30, FirstName = "Sean", LastName = "Bean", EmailAddress = "john@smith.com", Age = 37 },
                new Person(){ Id = 31, FirstName = "Charles", LastName = "Dance", EmailAddress = "john@smith.com", Age = 38 },
                new Person(){ Id = 32, FirstName = "Michelle", LastName = "Fairley", EmailAddress = "john@smith.com", Age = 39 },
            });

            modelBuilder.Entity<Address>().HasData(new List<Address>()
            {
                new Address() { Id = 1, AddressLine1 = "123 Test St", AddressLine2 = "", City = "Beverly Hills", State = "CA", ZipCode = "90210", PersonId = 1, Country = "USA"},
                new Address() { Id = 2, AddressLine1 = "123 Michigan Ave", AddressLine2 = "", City = "Chicago", State = "IL", ZipCode = "60612", PersonId = 2, Country = "USA"},
                new Address() { Id = 3, AddressLine1 = "100 1St St", AddressLine2 = "", City = "Chicago", State = "IL", ZipCode = "60612", PersonId = 2, Country = "USA"}
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
