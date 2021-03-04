using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCOre5WebApp.DAL.Migrations
{
    public partial class AddLookUps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "AK", "Alaska", 0 },
                    { "NH", "New Hampshire", 0 },
                    { "NJ", "New Jersey", 0 },
                    { "NM", "New Mexico", 0 },
                    { "NY", "New York", 0 },
                    { "NC", "New Carolina", 0 },
                    { "ND", "North Dakota", 0 },
                    { "OH", "Ohio", 0 },
                    { "OK", "Oklahoma", 0 },
                    { "OR", "Oregon", 0 },
                    { "PA", "Pennsylvania", 0 },
                    { "NV", "Nevada", 0 },
                    { "RI", "Rhode Island", 0 },
                    { "SD", "South Dakota", 0 },
                    { "TN", "Tennessee", 0 },
                    { "TX", "Texas", 0 },
                    { "UT", "Utah", 0 },
                    { "VT", "Vermont", 0 },
                    { "VA", "Virginia", 0 },
                    { "WA", "Washington", 0 },
                    { "WV", "West Virginia", 0 },
                    { "WI", "Wisconsis", 0 },
                    { "WY", "Wyoming", 0 },
                    { "SC", "South Carolina", 0 },
                    { "PR", "Puerto Rico", 0 },
                    { "NE", "Montana", 0 },
                    { "MO", "Mississippi", 0 },
                    { "AZ", "Arizona", 0 },
                    { "AR", "Arkansas", 0 },
                    { "CA", "California", 0 },
                    { "CO", "Colorado", 0 },
                    { "CT", "Connecticut", 0 },
                    { "DE", "Delaware", 0 },
                    { "DC", "District of Columbia", 0 },
                    { "FL", "Florida", 0 },
                    { "GA", "Georgia", 0 },
                    { "ID", "Hawaii", 0 },
                    { "MT", "Missouri", 0 },
                    { "IL", "Idaho", 0 },
                    { "IA", "Indiana", 0 },
                    { "KS", "Iowa", 0 },
                    { "KY", "Kansas", 0 },
                    { "LA", "Kentucky", 0 },
                    { "ME", "Louisiana", 0 },
                    { "MD", "Maine", 0 },
                    { "MA", "Maryland", 0 },
                    { "MI", "Massachusetts", 0 },
                    { "MN", "Michigan", 0 },
                    { "MS", "Minnesota", 0 },
                    { "IN", "Illinois", 0 },
                    { "USA", "United States of America", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "AK");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "AR");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "AZ");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "CO");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "CT");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "DC");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "FL");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "GA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "IA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "ID");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "IL");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "IN");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "KS");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "KY");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "LA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MD");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "ME");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MI");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MN");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MO");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MS");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "MT");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NC");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "ND");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NE");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NH");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NJ");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NM");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NV");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NY");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "OH");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "OK");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "OR");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "PA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "PR");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "RI");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "SC");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "SD");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "TN");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "TX");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "USA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "UT");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "VA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "VT");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "WA");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "WI");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "WV");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "WY");
        }
    }
}
