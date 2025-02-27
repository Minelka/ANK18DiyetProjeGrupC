using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class FoodMealUserModel : BaseViewModel
    {
        public int UserId { get; set; }

        public virtual UserModel User { get; set; }

        public int MealId { get; set; }

        public virtual MealModel? Meal { get; set; }

        public int? FoodId { get; set; }

        public virtual FoodModel? Food { get; set; }

        public int? BeveragesId { get; set; }

        public virtual BeveragesModel? Beverages { get; set; }

        public int? FoodValue { get; set; }
        public int? BeverageValue { get; set; }


    }
}
