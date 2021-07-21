using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalAPI.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Behavior", "DateAdded", "Gender", "Name", "Type" },
                values: new object[] { 2, "Loud and Obnoctus. But a gentel giant.", "June 8, 2012", "Male", "Boof", "Dog" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Behavior", "DateAdded", "Gender", "Name", "Type" },
                values: new object[] { 3, "Little shit. Low energy and calm during night.", "Febuary 28, 2015", "Male", "Charlie", "Cat" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Behavior", "DateAdded", "Gender", "Name", "Type" },
                values: new object[] { 4, "Wonderful and sublime. Does not enjoy the audiunce of childeren.", "April 1, 2018", "Female", "Spot", "Cat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
