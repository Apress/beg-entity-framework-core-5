using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddTestAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 1, "123 Test St", "", "Beverly Hills", "USA", 1, "CA", "90210" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 2, "123 Michigan Ave", "", "Chicago", "USA", 2, "IL", "60612" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 3, "100 1St St", "", "Chicago", "USA", 2, "IL", "60612" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
