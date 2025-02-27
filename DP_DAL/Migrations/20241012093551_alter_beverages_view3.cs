using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class alter_beverages_view3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vwUserBeveragesDailyTotalCalorie");
            migrationBuilder.Sql(@"CREATE VIEW vwUserBeveragesDailyTotalCalorie AS
                     SELECT
                     fmu.UserId as UserId,
                     u.Name as UserName,
                     b.Name as BeveragesName,
                     m.Name as BeveragesMealName,
                     p.Value as PortionValue,
                     fmu.Date as UserBeveragesDate,
                     b.Calorie as BeveragesCalorie,
                     (b.Calorie * p.Value) as UserBeveragesCalorie,
                     (p.Value * fmu.Value) as UserBeveragesPortionTotalValue
                     FROM
                     dbo.FoodMealUser as fmu
                     INNER JOIN dbo.Users as u ON u.Id = fmu.UserId
                     INNER JOIN dbo.Beverages as b ON b.Id = fmu.BeveragesId
                     INNER JOIN dbo.Meals as m ON m.Id = fmu.MealId
                     INNER JOIN dbo.Portions as p ON p.Id = b.PortionId  
                  ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vwUserBeveragesDailyTotalCalorie");
            migrationBuilder.Sql(@"CREATE VIEW vwUserBeveragesDailyTotalCalorie AS
                     SELECT
                     u.Name as UserName,
                     b.Name as BeveragesName,
                     m.Name as BeveragesMealName,
                     p.Value as PortionValue,
                     fmu.Date as UserBeveragesDate,
                     b.Calorie as BeveragesCalorie,
                     (b.Calorie * p.Value) as UserBeveragesCalorie,
                     (p.Value * fmu.Value) as UserBeveragesPortionTotalValue
                     FROM
                     dbo.FoodMealUser as fmu
                     INNER JOIN dbo.Users as u ON u.Id = fmu.UserId
                     INNER JOIN dbo.Beverages as b ON b.Id = fmu.BeveragesId
                     INNER JOIN dbo.Meals as m ON m.Id = fmu.MealId
                     INNER JOIN dbo.Portions as p ON p.Id = b.PortionId  
                  ");
        }
    }
}
