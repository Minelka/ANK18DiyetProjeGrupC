using DP_DAL.Entities.Concrete;
using DP_DAL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DP_DAL.Data
{
    public class DPDbContext : DbContext
    {
        DbSet<FoodMealUser> FoodMealUser { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Beverages> Beverages { get; set; }

        public DbSet<VWFood> VwFoods { get; set; }

        public DbSet<VWBeverages> VwBeverages { get; set; }

        public DbSet<Portion> Portions { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VWFood>().ToView("vwUserFoodDailyTotalCalorie"); /*Burası sadece fooddailyview i gösteriyor
                                                                                       beverages view içinde olmalı sanırım ?*/
            modelBuilder.Entity<VWBeverages>().ToView("vwUserBeveragesDailyTotalCalorie");


            modelBuilder.Entity<Beverages>()
                       .HasOne(b => b.Portion)
                       .WithMany(p => p.Beverages)
                       .HasForeignKey(b => b.PortionId)
                       .OnDelete(DeleteBehavior.Restrict);  // Bu kısım kaskadlı silme yerine Restrict uygular

            modelBuilder.Entity<Food>()
                .HasOne(f => f.Portion)
                .WithMany(p => p.Foods)
                .HasForeignKey(f => f.PortionId)
                .OnDelete(DeleteBehavior.Restrict);  // Aynı şekilde kaskad silmeyi Restrict ile engelliyoruz

            #region seedAdmin
            User admin = new User()
            {
                Id = 67,
                Name = "Admin",
                Surname = "SURNAME",
                Password = "123456*Admin",
                Email = "admin@gmail.com",
                UserType = UserType.Admin,
                Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286)
            };
            modelBuilder.Entity<User>().HasData(admin);
            #endregion


            #region seedUser
            User user = new User()
            {
                Id = 68,
                Name = "user",
                Surname = "SURNAME",
                Password = "123456*Admin",
                Email = "admin@gmail.com",
                UserType = UserType.User,
                Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286)
            };



            modelBuilder.Entity<UserInfo>().HasData(new UserInfo
            {
                Id = 1,
                UserId = 68,
                Gender = Gender.Male,
                BirthDate = new DateOnly(1990, 1, 1),
                Height = 180,
                Weight = 75,
                Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286)
            });
            modelBuilder.Entity<User>().HasData(user);
            #endregion

            #region seedFoodMealUser
            modelBuilder.Entity<FoodMealUser>().HasData(new FoodMealUser { Id = 1, UserId = 68, MealId = 1, FoodId = 1, BeveragesId = 1, Date = new DateOnly(2024, 10, 13), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 2, UserId = 68, MealId = 1, FoodId = 2, BeveragesId = 3, Date = new DateOnly(2024, 10, 12), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 3, UserId = 68, MealId = 2, FoodId = 3, BeveragesId = 1, Date = new DateOnly(2024, 10, 11), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 4, UserId = 68, MealId = 3, FoodId = 2, BeveragesId = 2, Date = new DateOnly(2024, 10, 10), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 5, UserId = 68, MealId = 3, FoodId = 2, BeveragesId = 2, Date = new DateOnly(2024, 10, 09), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 6, UserId = 68, MealId = 2, FoodId = 1, BeveragesId = 1, Date = new DateOnly(2024, 10, 06), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 7, UserId = 68, MealId = 1, FoodId = 2, BeveragesId = 3, Date = new DateOnly(2024, 10, 05), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 8, UserId = 68, MealId = 2, FoodId = 3, BeveragesId = 2, Date = new DateOnly(2024, 09, 30), FoodValue = 1, BeverageValue = 2 },
                  new FoodMealUser { Id = 9, UserId = 68, MealId = 3, FoodId = 3, BeveragesId = 1, Date = new DateOnly(2024, 09, 01), FoodValue = 1, BeverageValue = 2 });

            #endregion

            #region SeedMeal

            modelBuilder.Entity<Meal>().HasData(
                new Meal { Id = 1, Name = "Kahvaltı", Created = new DateTime(2024, 10, 13, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) },
                new Meal { Id = 2, Name = "Öğlen Yemeği", Created = new DateTime(2024, 10, 12, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) },
                new Meal { Id = 3, Name = "Akşam Yemeği", Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) }
            );
            #endregion
            #region SeedPortion

            modelBuilder.Entity<Portion>().HasData(new Portion
            {
                Id = 1,
                Name = "Gram",
                Value = 1,
                Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286)

            },
                    new Portion { Id = 2, Name = "Bardak", Value = 1, Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) }
                ,
                    new Portion { Id = 3, Name = "Tabak", Value = 1, Created = new DateTime(2024, 10, 02, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) }
                );
            #endregion

            #region SeedFood

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 1,
                Name = "Yağlama",
                Calorie = 250,
                PortionId = 1,
                Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286)

            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 2,
                Name = "Mantı",
                Calorie = 780,
                PortionId = 3,
                Created = new DateTime(2024, 10, 11, 11, 27, 11, 412, DateTimeKind.Local).AddTicks(5286)

            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 3,
                Name = "Patlıcan Balıkı",
                Calorie = 1100,
                PortionId = 3,
                Created = new DateTime(2024, 9, 11, 11, 27, 11, 412, DateTimeKind.Local).AddTicks(5286)

            });
            #endregion

            #region seedBeverage

            modelBuilder.Entity<Beverages>().HasData(new Beverages { Id = 1, Name = "Portakal suyu", Calorie = 400, PortionId = 2, Created = new DateTime(2024, 10, 11, 11, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) },
                   new Beverages { Id = 2, Name = "Çikolu Süt", Calorie = 250, PortionId = 2, Created = new DateTime(2024, 10, 11, 09, 43, 11, 412, DateTimeKind.Local).AddTicks(5286) },
                   new Beverages { Id = 3, Name = "Ayran", Calorie = 100, PortionId = 2, Created = new DateTime(2024, 10, 11, 11, 43, 41, 412, DateTimeKind.Local).AddTicks(5286) });

            #endregion

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string serverMinel = "DESKTOP-J5485VO";
            string serverEfnan = "DESKTOP-VAQBE6U";
            string serverAlkin = "VMI1229542";

            //string connStr = $"Server={serverEfnan};Database=ShapeUpDbTemp;Trusted_Connection=true;Trustservercertificate=true";
            string connStr = $"Server={serverMinel};Database=ShapeUpDb;Trusted_Connection=true;Trustservercertificate=true";

            optionsBuilder.UseSqlServer(connStr);
        }



    }
}
