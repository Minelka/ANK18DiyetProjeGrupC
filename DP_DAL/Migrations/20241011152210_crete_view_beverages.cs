using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class crete_view_beverages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW vwUserBeveragesDailyTotalCalorie AS
                     SELECT
                     u.Name as UserName,
                     b.Name as BeveragesName,
                     m.Name as FoodMealName,
                     p.Value as PortionValue,
                     fmu.Date as UserFoodDate,
                     b.Calorie as BeveragesCalorie,
                     (b.Calorie * p.Value) as UserBeveragesCalorie,
                     (p.Value * fmu.Value) as UserFoodPortionTotalValue
                     FROM
                     dbo.FoodMealUser as fmu
                     INNER JOIN dbo.Users as u ON u.Id = fmu.UserId
                     INNER JOIN dbo.Beverages as b ON b.Id = fmu.BeveragesId
                     INNER JOIN dbo.Meals as m ON m.Id = fmu.MealId
                     INNER JOIN dbo.Portion as p ON p.Id = b.PortionId  
                  ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vwUserBeveragesDailyTotalCalorie");
        }
    }
}
