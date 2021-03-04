using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class PersonParentChildren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Addresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "PersonPerson",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    ParentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPerson", x => new { x.ChildrenId, x.ParentsId });
                    table.ForeignKey(
                        name: "FK_PersonPerson_Persons_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPerson_Persons_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonPerson_ParentsId",
                table: "PersonPerson",
                column: "ParentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonPerson");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Persons");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
