using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Food_Wiew_Alter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vwUserFoodDailyTotalCalorie");
            migrationBuilder.Sql(@"CREATE VIEW vwUserFoodDailyTotalCalorie AS
                                    SELECT
                                    fmu.UserId as UserId,
                                    u.Name as UserName,
                                    f.Name as FoodName,
                                    m.Name as FoodMealName,
                                    p.Name as PortionName,
                                    fmu.Value as UserFoodValue,
                                    p.Value as PortionValue,
                                    fmu.Date as UserFoodDate,
                                    f.Calorie as FoodCalorie,
                                    (f.Calorie * p.Value) as UserFoodCalorie,
                                    (p.Value * fmu.Value) as UserFoodPortionTotalValue
                                    FROM
                                    dbo.FoodMealUser as fmu
                                    INNER JOIN dbo.Users as u ON u.Id = fmu.UserId
                                    INNER JOIN dbo.Foods as f ON f.Id = fmu.FoodId
                                    INNER JOIN dbo.Meals as m ON m.Id = fmu.MealId
                                    INNER JOIN dbo.Portions as p ON p.Id = f.PortionId
                                    WHERE fmu.BeveragesId is null   
                                                      ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW vwUserFoodDailyTotalCalorie");
            migrationBuilder.Sql(@"CREATE VIEW vwUserFoodDailyTotalCalorie AS
                                    SELECT
                                    fmu.UserId as UserId,
                                    u.Name as UserName,
                                    f.Name as FoodName,
                                    m.Name as FoodMealName,
                                    p.Value as PortionValue,
                                    fmu.Date as UserFoodDate,
                                    f.Calorie as FoodCalorie,
                                    (f.Calorie * p.Value) as UserFoodCalorie,
                                    (p.Value * fmu.Value) as UserFoodPortionTotalValue
                                    FROM
                                    dbo.FoodMealUser as fmu
                                    INNER JOIN dbo.Users as u ON u.Id = fmu.UserId
                                    INNER JOIN dbo.Foods as f ON f.Id = fmu.FoodId
                                    INNER JOIN dbo.Meals as m ON m.Id = fmu.MealId
                                    INNER JOIN dbo.Portions as p ON p.Id = f.PortionId   
                  ");
        }
    }
}
