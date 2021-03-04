﻿// <auto-generated />
using System;
using EFCOre5WebApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore5WebApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
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
                            Code = "HI",
                            Description = "Hawaii",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "ID",
                            Description = "Idaho",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "IL",
                            Description = "Illinois",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "IN",
                            Description = "Indiana",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "IA",
                            Description = "Iowa",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "KS",
                            Description = "Kansas",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "KY",
                            Description = "Kentucky",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "LA",
                            Description = "Louisiana",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "ME",
                            Description = "Maine",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MD",
                            Description = "Maryland",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MA",
                            Description = "Massachusetts",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MI",
                            Description = "Michigan",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MN",
                            Description = "Minnesota",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MS",
                            Description = "Mississippi",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MO",
                            Description = "Missouri",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "MT",
                            Description = "Montana",
                            LookUpType = 0
                        },
                        new
                        {
                            Code = "NE",
                            Description = "Nebraska",
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

                    b.ToTable("Persons");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PersonPerson", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<int>("ParentsId")
                        .HasColumnType("int");

                    b.HasKey("ChildrenId", "ParentsId");

                    b.HasIndex("ParentsId");

                    b.ToTable("PersonPerson");
                });

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.Address", b =>
                {
                    b.HasOne("EFCore5WebApp.Core.Entities.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonPerson", b =>
                {
                    b.HasOne("EFCore5WebApp.Core.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore5WebApp.Core.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("ParentsId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore5WebApp.Core.Entities.Person", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
