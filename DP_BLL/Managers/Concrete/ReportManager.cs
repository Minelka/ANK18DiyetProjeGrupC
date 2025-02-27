using AutoMapper;
using DP_BLL.Models;
using DP_DAL.Entities.Concrete;
using DP_DAL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Managers.Concrete
{
    public class ReportManager
    {
        private readonly UserReportService _userReportService;
        private IConfigurationProvider _config;
        private IMapper _mapper;

        public ReportManager()
        {
            _userReportService = new UserReportService();
            _config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<VWFood,VwFoodReportModel>();
                cfg.CreateMap<VWFood, VwUsersMealTotalCalorieModel>()
                   .ForMember(d => d.UserName, m => m.MapFrom(s => s.UserName))
                   .ForMember(d => d.FoodMeal, m => m.MapFrom(s => s.FoodMealName))
                   .ForMember(d => d.TotalCalorie, m => m.MapFrom(s => s.UserFoodValue * s.FoodCalorie));
            });
            _mapper = new Mapper(_config);
        }

        public ICollection<VwFoodReportModel> GetAllUsers()
        {
            ICollection<VWFood> vWFoods = _userReportService.UserGetAll();

            return _mapper.Map<ICollection<VwFoodReportModel>>(vWFoods);
        }

        


        public ICollection<VwBeveragesReportModel> GetAllBeveragesUsers()
        {
            ICollection<VWBeverages> VWBeverages = _userReportService.UserGetBeverages();

            return _mapper.Map<ICollection<VwBeveragesReportModel>>(VWBeverages);
        }



        public ICollection<VwUsersMealTotalCalorieModel> GeAllUserForMealTotatCalorie()
        {
            ICollection<VWFood> vWFoods = _userReportService.UserGetAll();

            return  vWFoods.GroupBy(g => new { g.UserName, g.FoodMealName })
                   .Select(s => new VwUsersMealTotalCalorieModel { UserName = s.Key.UserName, FoodMeal = s.Key.FoodMealName, TotalCalorie = s.Sum(s => s.UserFoodCalorie) })
                   .ToList();

        }

        public ICollection<VwUsersMealTotalCalorieModel> GeAllUserMealTotatCalorie()
        {
            ICollection<VWFood> vWFoods = _userReportService.UserGetAll();

            return _mapper.Map<ICollection<VwUsersMealTotalCalorieModel>>(vWFoods);

        }

        public ICollection<VwUserTotalCalorieModel> GetUserTotalCalories()
        {
            // Yiyecek ve içecek verilerini alıyoruz
            ICollection<VWFood> foodData = _userReportService.UserGetAll();
            ICollection<VWBeverages> beveragesData = _userReportService.UserGetBeverages();

            // Yiyecek verilerini grupluyoruz
            var foodCalories = foodData.GroupBy(g => g.UserName)
                .Select(s => new
                {
                    UserName = s.Key,
                    TotalFoodCalorie = s.Sum(f => f.UserFoodCalorie)
                });

            // İçecek verilerini grupluyoruz
            var beveragesCalories = beveragesData.GroupBy(g => g.UserName)
                .Select(s => new
                {
                    UserName = s.Key,
                    TotalBeveragesCalorie = s.Sum(b => b.UserBeveragesCalorie)
                });

            // Yiyecek ve içecek verilerini kullanıcı bazında birleştiriyoruz
            var totalCalories = from food in foodCalories
                                join beverage in beveragesCalories
                                on food.UserName equals beverage.UserName into joined
                                from beverage in joined.DefaultIfEmpty()
                                select new VwUserTotalCalorieModel
                                {
                                    UserName = food.UserName,
                                    TotalFoodCalorie = food.TotalFoodCalorie,
                                    TotalBeveragesCalorie = beverage?.TotalBeveragesCalorie ?? 0
                                };

            return totalCalories.ToList();
        }



        //Kullanıcıların Belirli Bir Tarih Aralığında Tükettiği Yemeklerin Listesi
        public ICollection<VwFoodReportModel> GetUserFoodsByDateRange(DateOnly startDate, DateOnly endDate)
        {
            ICollection<VWFood> vwFoods = _userReportService.UserGetAll();

            return vwFoods.Where(f => f.UserFoodDate >= startDate && f.UserFoodDate <= endDate)
                   .Select(f => new VwFoodReportModel
                   {
                       UserName = f.UserName,
                       FoodName = f.FoodName,
                       FoodMealName = f.FoodMealName,
                       PortionName = f.PortionName,
                       UserFoodValue = f.UserFoodValue,
                       UserFoodCalorie = f.UserFoodValue * f.FoodCalorie
                   }).ToList();
        }


        //Kullanıcının Belirli Bir Tarihte Tükettiği İçeceklerin Toplam Kalorisi ve Porsiyon Değeri
        public ICollection<VwBeveragesReportModel> GetUserBeveragesByDate(DateOnly targetDate)
        {
            ICollection<VWBeverages> vwBeverages = _userReportService.UserGetBeverages();

            return vwBeverages.Where(b => b.UserBeveragesDate == targetDate)
                   .GroupBy(g => new { g.UserName, g.BeveragesMealName })
                   .Select(s => new VwBeveragesReportModel
                   {
                       UserName = s.Key.UserName,
                       BeveragesMealName = s.Key.BeveragesMealName,
                       UserBeveragesCalorie = s.Sum(x => x.UserBeveragesValue * x.BeveragesCalorie),
                       UserBeveragesPortionTotalValue = s.Sum(x => x.PortionValue * x.UserBeveragesValue)
                   }).ToList();
        }


        // Kullanıcının belirli bir öğünde tükettiği toplam kalori
        public VwFoodReportModel GetTopCalorieUserForMeal(string mealName)
        {
            ICollection<VWFood> vwFoods = _userReportService.UserGetAll();

            return vwFoods.Where(f => f.FoodMealName == mealName)
                   .OrderByDescending(f => f.UserFoodValue * f.FoodCalorie)
                   .Select(f => new VwFoodReportModel
                   {
                       UserName = f.UserName,
                       FoodName = f.FoodName,
                       FoodMealName = f.FoodMealName,
                       UserFoodCalorie = f.UserFoodValue * f.FoodCalorie
                   }).FirstOrDefault();
        }

        //public ICollection<CombinedReportModel> GetCombinedUserReport(DateOnly targetDate)
        //{
        //    // Kullanıcıların yiyecek raporlarını al
        //    ICollection<VWFood> vWFoods = _userReportService.UserGetAll();

        //    // Kullanıcıların içecek raporlarını al
        //    ICollection<VWBeverages> vwBeverages = _userReportService.UserGetBeverages();

        //    // İçecek raporlarını filtrele ve grupla
        //    var beveragesReport = vwBeverages
        //        .Where(b => b.UserBeveragesDate == targetDate)
        //        .GroupBy(g => new { g.UserName, g.BeveragesMealName })
        //        .Select(s => new
        //        {
        //            UserName = s.Key.UserName,
        //            BeveragesMealName = s.Key.BeveragesMealName,
        //            TotalBeveragesCalorie = s.Sum(x => x.UserBeveragesValue * x.BeveragesCalorie),
        //            TotalBeveragesPortionValue = s.Sum(x => x.PortionValue * x.UserBeveragesValue)
        //        }).ToList();

        //    // Yiyecek raporlarını grupla
        //    var foodReport = vWFoods
        //        .GroupBy(g => g.UserName)
        //        .Select(s => new
        //        {
        //            UserName = s.Key,
        //            TotalFoodCalorie = s.Sum(x => x.FoodCalorie) // Varsayılan yiyecek kalori alanı
        //        }).ToList();

        //    // Her iki raporu birleştir
        //    var combinedReport = from food in foodReport
        //                         join beverage in beveragesReport
        //                         on food.UserName equals beverage.UserName into combined
        //                         from c in combined.DefaultIfEmpty() // Join işlemi
        //                         select new CombinedReportModel
        //                         {
        //                             UserName = food.UserName,
        //                             BeveragesMealName = c?.BeveragesMealName,
        //                             TotalFoodCalorie = food.TotalFoodCalorie,
        //                             TotalBeveragesCalorie = c?.TotalBeveragesCalorie ?? 0,
        //                             TotalBeveragesPortionValue = c?.TotalBeveragesPortionValue ?? 0
        //                         };

        //    return combinedReport.ToList();
        //}



    }
}
