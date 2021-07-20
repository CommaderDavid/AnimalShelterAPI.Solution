using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateAdded",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Behavior", "DateAdded", "Gender", "Name", "Type" },
                values: new object[] { 1, "Wonderful and sublime. Fantastic around kids.", "April 2, 2009", "Female", "Malinda", "Dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "DateAdded",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
