using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class ıd_degisikligi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "UserInfo");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "FoodMealUser");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "FoodMealUser");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "FoodMealUser");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "ModifiedUserId",
                table: "Beverages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "UserInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "UserInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "UserInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Portions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Portions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Portions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Meals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "FoodMealUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "FoodMealUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "FoodMealUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedUserId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedUserId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedUserId", "DeletedUserId", "ModifiedUserId" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedUserId", "DeletedUserId", "ModifiedUserId" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedUserId", "DeletedUserId", "ModifiedUserId" },
                values: new object[] { 0, 0, 0 });
        }
    }
}
