using Microsoft.EntityFrameworkCore.Migrations;

namespace OdeToFood.Migrations
{
    public partial class AddedCuisine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cuisine",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuisine",
                table: "Restaurants");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);
        }
    }
}
