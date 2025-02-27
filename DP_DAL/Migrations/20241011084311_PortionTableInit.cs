using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class PortionTableInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "Portion",
                table: "Foods",
                newName: "PortionId");

            migrationBuilder.CreateTable(
                name: "Portion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portion", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "CreatedUserId", "Deleted", "DeletedUserId", "Email", "IsActive", "Modified", "ModifiedUserId", "Name", "Password", "Surname" },
                values: new object[] { 67, new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286), 0, null, 0, "admin@gmail.com", true, null, 0, "Admin", "123456*Admin", "SURNAME" });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_PortionId",
                table: "Foods",
                column: "PortionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods",
                column: "PortionId",
                principalTable: "Portion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "Portion");

            migrationBuilder.DropIndex(
                name: "IX_Foods_PortionId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.RenameColumn(
                name: "PortionId",
                table: "Foods",
                newName: "Portion");

            migrationBuilder.AddColumn<double>(
                name: "Calories",
                table: "Foods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "Foods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
