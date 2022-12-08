using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopRegistration.Migrations
{
    public partial class addmigratiosecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Registration",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Registration");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Registration",
                newName: "Name");
        }
    }
}
