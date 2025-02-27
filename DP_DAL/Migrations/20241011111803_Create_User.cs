using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Create_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                column: "UserType",
                value: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "CreatedUserId", "Deleted", "DeletedUserId", "Email", "IsActive", "Modified", "ModifiedUserId", "Name", "Password", "Surname", "UserType" },
                values: new object[] { 68, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), 0, null, 0, "admin@gmail.com", true, null, 0, "user", "123456*Admin", "SURNAME", 2 });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "Id", "BirthDate", "Created", "CreatedUserId", "Deleted", "DeletedUserId", "Gender", "Height", "IsActive", "Modified", "ModifiedUserId", "UserId", "Weight" },
                values: new object[] { 1, new DateOnly(1990, 1, 1), new DateTime(2024, 10, 11, 14, 18, 2, 345, DateTimeKind.Local).AddTicks(5906), 0, null, 0, 0, 180, true, null, 0, 68, 75 });
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
                keyValue: 68);

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");
        }
    }
}
