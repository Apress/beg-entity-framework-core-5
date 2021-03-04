using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class MorePersonData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CreatedOn", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Jane", "Foster" },
                    { 30, 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Sean", "Bean" },
                    { 29, 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Hannah", "Murray" },
                    { 28, 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Jack", "Gleeson" },
                    { 27, 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Jacob", "Anderson" },
                    { 26, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Kristofer", "Hivju" },
                    { 25, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Jerome", "Flynn" },
                    { 24, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Rosie", "Leslie" },
                    { 23, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Richard", "Madden" },
                    { 22, 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Natalie", "Dormer" },
                    { 21, 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Jason", "Mamoa" },
                    { 20, 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Aidan", "Gillen" },
                    { 19, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Liam", "Cunningham" },
                    { 18, 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "John", "Bradley" },
                    { 17, 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Conleth", "Hil" },
                    { 16, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Carice", "van Houten" },
                    { 15, 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Nathalie", "Emmanuel" },
                    { 14, 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Alfie", "Allen" },
                    { 13, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Iain", "Glen" },
                    { 12, 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Isac", "Hempstead" },
                    { 11, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Gwendoline", "Christie" },
                    { 10, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Nikolaj", "Coster-Waldau" },
                    { 9, 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Peter", "Dinklage" },
                    { 8, 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Lena", "Headey" },
                    { 7, 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Sophie", "Turner" },
                    { 6, 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Kit", "Harrington" },
                    { 5, 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Maisie", "Williams" },
                    { 4, 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Burt", "Reynolds" },
                    { 31, 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Charles", "Dance" },
                    { 32, 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Michelle", "Fairley" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
