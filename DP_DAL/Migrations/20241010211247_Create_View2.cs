using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Create_View2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breakfast",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Dinner",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Lunch",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Snack",
                table: "Meals");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Meals");

            migrationBuilder.AddColumn<string>(
                name: "Breakfast",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dinner",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lunch",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Snack",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
