using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class fazladan_seed_eklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beverages",
                columns: new[] { "Id", "Calorie", "Created", "Deleted", "IsActive", "Modified", "Name", "PortionId" },
                values: new object[,]
                {
                    { 2, 250, new DateTime(2024, 10, 11, 9, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Çikolu Süt", 2 },
                    { 3, 100, new DateTime(2024, 10, 11, 11, 43, 41, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Ayran", 2 }
                });

            migrationBuilder.UpdateData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 10, 13));

            migrationBuilder.InsertData(
                table: "FoodMealUser",
                columns: new[] { "Id", "BeverageValue", "BeveragesId", "Created", "Date", "Deleted", "FoodId", "FoodValue", "IsActive", "MealId", "Modified", "UserId", "UserInfoId" },
                values: new object[] { 6, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 10, 6), null, 1, 1, false, 2, null, 68, null });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 13, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 12, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.InsertData(
                table: "Portions",
                columns: new[] { "Id", "Created", "Deleted", "IsActive", "Modified", "Name", "Value" },
                values: new object[] { 3, new DateTime(2024, 10, 2, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Tabak", 1 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "Created", "Deleted", "IsActive", "Modified", "Name", "PortionId" },
                values: new object[,]
                {
                    { 2, 780, new DateTime(2024, 10, 11, 11, 27, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Mantı", 3 },
                    { 3, 1100, new DateTime(2024, 9, 11, 11, 27, 11, 412, DateTimeKind.Local).AddTicks(5286), null, false, null, "Patlıcan Balıkı", 3 }
                });

            migrationBuilder.InsertData(
                table: "FoodMealUser",
                columns: new[] { "Id", "BeverageValue", "BeveragesId", "Created", "Date", "Deleted", "FoodId", "FoodValue", "IsActive", "MealId", "Modified", "UserId", "UserInfoId" },
                values: new object[,]
                {
                    { 2, 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 10, 12), null, 2, 1, false, 1, null, 68, null },
                    { 3, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 10, 11), null, 3, 1, false, 2, null, 68, null },
                    { 4, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 10, 10), null, 2, 1, false, 3, null, 68, null },
                    { 5, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 10, 9), null, 2, 1, false, 3, null, 68, null },
                    { 7, 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 10, 5), null, 2, 1, false, 1, null, 68, null },
                    { 8, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 9, 30), null, 3, 1, false, 2, null, 68, null },
                    { 9, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2024, 9, 1), null, 3, 1, false, 3, null, 68, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Beverages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Portions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "FoodMealUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(1999, 1, 1));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286));
        }
    }
}
