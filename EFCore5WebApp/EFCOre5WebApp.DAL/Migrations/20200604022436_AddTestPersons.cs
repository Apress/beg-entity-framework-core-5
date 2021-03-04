using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCOre5WebApp.DAL.Migrations
{
    public partial class AddTestPersons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Persons",
                columns: new[] { "Id", "CreatedOn", "EmailAddress", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "John", "Smith" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Persons",
                columns: new[] { "Id", "CreatedOn", "EmailAddress", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Susan", "Jones" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
