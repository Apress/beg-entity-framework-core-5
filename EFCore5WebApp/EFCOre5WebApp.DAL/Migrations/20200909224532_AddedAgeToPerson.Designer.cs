﻿// <auto-generated />
using System;
using EFCOre5WebApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCOre5WebApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200909224532_AddedAgeToPerson")]
    partial class AddedAgeToPerson
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.8.20407.4");

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "123 Test St",
                            AddressLine2 = "",
                            City = "Beverly Hills",
                            Country = "USA",
                            PersonId = 1,
                            State = "CA",
                            ZipCode = "90210"
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "123 Michigan Ave",
                            AddressLine2 = "",
                            City = "Chicago",
                            Country = "USA",
                            PersonId = 2,
                            State = "IL",
                            ZipCode = "60612"
                        },
                        new
                        {
                            Id = 3,
                            AddressLine1 = "100 1St St",
                            AddressLine2 = "",
                            City = "Chicago",
                            Country = "USA",
                            PersonId = 2,
                            State = "IL",
                            ZipCode = "60612"
                        });
                });

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.LookUp", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LookUpType")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("LookUps");

                    b.HasData(
                        new
                        {
                            Code = "AL",
                            Description = "Alabama",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "AK",
                            Description = "Alaska",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "AZ",
                            Description = "Arizona",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "AR",
                            Description = "Arkansas",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "CA",
                            Description = "California",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "CO",
                            Description = "Colorado",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "CT",
                            Description = "Connecticut",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "DE",
                            Description = "Delaware",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "DC",
                            Description = "District of Columbia",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "FL",
                            Description = "Florida",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "GA",
                            Description = "Georgia",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "ID",
                            Description = "Hawaii",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "IL",
                            Description = "Idaho",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "IN",
                            Description = "Illinois",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "IA",
                            Description = "Indiana",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "KS",
                            Description = "Iowa",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "KY",
                            Description = "Kansas",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "LA",
                            Description = "Kentucky",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "ME",
                            Description = "Louisiana",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MD",
                            Description = "Maine",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MA",
                            Description = "Maryland",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MI",
                            Description = "Massachusetts",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MN",
                            Description = "Michigan",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MS",
                            Description = "Minnesota",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MO",
                            Description = "Mississippi",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MT",
                            Description = "Missouri",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NE",
                            Description = "Montana",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NV",
                            Description = "Nevada",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NH",
                            Description = "New Hampshire",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NJ",
                            Description = "New Jersey",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NM",
                            Description = "New Mexico",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NY",
                            Description = "New York",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NC",
                            Description = "New Carolina",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "ND",
                            Description = "North Dakota",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "OH",
                            Description = "Ohio",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "OK",
                            Description = "Oklahoma",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "OR",
                            Description = "Oregon",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "PA",
                            Description = "Pennsylvania",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "RI",
                            Description = "Rhode Island",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "SC",
                            Description = "South Carolina",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "SD",
                            Description = "South Dakota",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "TN",
                            Description = "Tennessee",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "TX",
                            Description = "Texas",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "UT",
                            Description = "Utah",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "VT",
                            Description = "Vermont",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "VA",
                            Description = "Virginia",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "WA",
                            Description = "Washington",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "WV",
                            Description = "West Virginia",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "WI",
                            Description = "Wisconsis",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "WY",
                            Description = "Wyoming",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "PR",
                            Description = "Puerto Rico",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "USA",
                            Description = "United States of America",
                            LookUpType = 1
                        });
                });

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Persons", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "john@smith.com",
                            FirstName = "John",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 2,
                            Age = 30,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "john@smith.com",
                            FirstName = "Susan",
                            LastName = "Jones"
                        });
                });

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.Address", b =>
                {
                    b.HasOne("EFCore5WebApp.Core.Entities.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
