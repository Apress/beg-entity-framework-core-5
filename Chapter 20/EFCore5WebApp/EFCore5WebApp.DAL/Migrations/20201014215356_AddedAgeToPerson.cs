using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class AddedAgeToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Age",
                value: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");
        }
    }
}
