using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddTestPersons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "EmailAddress", "FirstName", "LastName" },
                values: new object[] { 1, "john@smith.com", "John", "Smith" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "EmailAddress", "FirstName", "LastName" },
                values: new object[] { 2, "john@smith.com", "Susan", "Jones" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
