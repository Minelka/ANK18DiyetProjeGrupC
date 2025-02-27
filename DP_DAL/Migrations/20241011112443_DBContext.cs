using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class DBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 11, 14, 24, 42, 353, DateTimeKind.Local).AddTicks(2234));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 11, 14, 18, 2, 345, DateTimeKind.Local).AddTicks(5906));
        }
    }
}
