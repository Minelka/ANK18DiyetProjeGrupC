using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Create_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Created", "Deleted", "IsActive", "Modified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Kahvaltı" },
                    { 2, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Öğlen Yemeği" },
                    { 3, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Akşam Yemeği" }
                });

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "Id", "Created", "Deleted", "IsActive", "Modified", "Name", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Gram", 1 },
                    { 2, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Bardak", 1 }
                });

            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "Id", "Calorie", "Created", "Deleted", "IsActive", "Modified", "Name", "PortionId" },
                values: new object[] { 1, 400.0, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Portakal suyu", 2 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "Created", "Deleted", "IsActive", "Modified", "Name", "PortionId" },
                values: new object[] { 1, 250.0, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Yağlama", 1 });

            migrationBuilder.InsertData(
                table: "FoodMealUser",
                columns: new[] { "Id", "BeveragesId", "Created", "Date", "Deleted", "FoodId", "IsActive", "MealId", "Modified", "UserId", "UserInfoId", "Value" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1999, 1, 1), null, 1, false, 1, null, 68, null, 650 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
