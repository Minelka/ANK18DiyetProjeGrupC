using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Create_View3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW vwUserFoodDailyTotalCalorie AS
                                 SELECT
                                 u.Name as UserName,
                                 f.Name as FoodName,
                                 m.Name as FoodMealName,
                                 f.Quantity as PortionValue,
                                 fmu.Date as UserFoodDate,
                                 f.Calorie as FoodCalorie,
                                 b.Name as  BeveragesName,
                                 (f.Calorie * f.Quantity) as UserFoodCalorie
                                 FROM
                                 dbo.FoodMealUser as fmu
                                 INNER JOIN dbo.Users as u ON u.Id = fmu.UserId
                                 INNER JOIN dbo.Foods as f ON f.Id = fmu.FoodId
                                 INNER JOIN dbo.Meals as m ON m.Id = fmu.MealId
                                 INNER JOIN dbo.Beverages as b ON b.Id = fmu.BeveragesId  
                                 ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vwUserFoodDailyTotalCalorie");
        }
    }
}
