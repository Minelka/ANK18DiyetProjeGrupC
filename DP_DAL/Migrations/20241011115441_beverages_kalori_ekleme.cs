using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class beverages_kalori_ekleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Calorie",
                table: "Beverages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calorie",
                table: "Beverages");
        }
    }
}
