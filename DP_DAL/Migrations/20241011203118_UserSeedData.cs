using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "CreatedUserId", "Deleted", "DeletedUserId", "Email", "IsActive", "Modified", "ModifiedUserId", "Name", "Password", "Surname", "UserType" },
                values: new object[,]
                {
                    { 67, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), 0, null, 0, "admin@gmail.com", true, null, 0, "Admin", "123456*Admin", "SURNAME", 1 },
                    { 68, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), 0, null, 0, "admin@gmail.com", true, null, 0, "user", "123456*Admin", "SURNAME", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "BirthDate", "Created", "CreatedUserId", "Deleted", "DeletedUserId", "Gender", "Height", "IsActive", "Modified", "ModifiedUserId", "UserId", "Weight" },
                values: new object[] { 1, new DateOnly(1990, 1, 1), new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), 0, null, 0, 0, 180, true, null, 0, 68, 75 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);
        }
    }
}
