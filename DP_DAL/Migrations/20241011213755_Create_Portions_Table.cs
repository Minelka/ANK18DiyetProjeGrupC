using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Create_Portions_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_Portion_PortionId",
                table: "Beverages");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Portion_PortionId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portion",
                table: "Portion");

            migrationBuilder.RenameTable(
                name: "Portion",
                newName: "Portions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portions",
                table: "Portions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_Portions_PortionId",
                table: "Beverages",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Portions_PortionId",
                table: "Foods",
                column: "PortionId",
                principalTable: "Portions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_Portions_PortionId",
                table: "Beverages");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Portions_PortionId",
                table: "Foods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portions",
                table: "Portions");

            migrationBuilder.RenameTable(
                name: "Portions",
                newName: "Portion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portion",
                table: "Portion",
                column: "Id");

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
    }
}
