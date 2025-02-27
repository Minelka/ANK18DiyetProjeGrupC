using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class foodsdrinkfixedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "PortionId",
                table: "Beverages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_PortionId",
                table: "Beverages",
                column: "PortionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_Portion_PortionId",
                table: "Beverages",
                column: "PortionId",
                principalTable: "Portion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods",
                column: "PortionId",
                principalTable: "Portion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_Portion_PortionId",
                table: "Beverages");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_PortionId",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "PortionId",
                table: "Beverages");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods",
                column: "PortionId",
                principalTable: "Portion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
