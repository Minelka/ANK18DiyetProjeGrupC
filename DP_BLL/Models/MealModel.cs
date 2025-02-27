using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class MealModel : BaseViewModel
    {
        public string Name { get; set; }

        public List<FoodMealUserModel> FoodMealUsers { get; set; } = new List<FoodMealUserModel>();
    }
}
