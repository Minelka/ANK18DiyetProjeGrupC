using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class denemeeeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodMealUser_Beverages_BeveragesId",
                table: "FoodMealUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodMealUser_Foods_FoodId",
                table: "FoodMealUser");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "FoodMealUser");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "FoodMealUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BeveragesId",
                table: "FoodMealUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BeverageValue",
                table: "FoodMealUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodValue",
                table: "FoodMealUser",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeverageValue", "FoodValue" },
                values: new object[] { 2, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodMealUser_Beverages_BeveragesId",
                table: "FoodMealUser",
                column: "BeveragesId",
                principalTable: "Beverages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodMealUser_Foods_FoodId",
                table: "FoodMealUser",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodMealUser_Beverages_BeveragesId",
                table: "FoodMealUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodMealUser_Foods_FoodId",
                table: "FoodMealUser");

            migrationBuilder.DropColumn(
                name: "BeverageValue",
                table: "FoodMealUser");

            migrationBuilder.DropColumn(
                name: "FoodValue",
                table: "FoodMealUser");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "FoodMealUser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeveragesId",
                table: "FoodMealUser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "FoodMealUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "Value",
                value: 650);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodMealUser_Beverages_BeveragesId",
                table: "FoodMealUser",
                column: "BeveragesId",
                principalTable: "Beverages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodMealUser_Foods_FoodId",
                table: "FoodMealUser",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
