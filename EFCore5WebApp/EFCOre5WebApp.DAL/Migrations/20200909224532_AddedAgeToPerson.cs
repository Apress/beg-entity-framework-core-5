using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCOre5WebApp.DAL.Migrations
{
    public partial class AddedAgeToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_LookUps_LookUpType_Enum_Constraint",
                table: "LookUps");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                schema: "dbo",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Age",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "dbo",
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
                schema: "dbo",
                table: "Persons");

            migrationBuilder.AddCheckConstraint(
                name: "CK_LookUps_LookUpType_Enum_Constraint",
                table: "LookUps",
                sql: "[LookUpType] IN(0, 1)");
        }
    }
}
