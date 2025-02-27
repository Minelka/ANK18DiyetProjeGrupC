using DP_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class BeveragesModel: BaseViewModel
    {
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int PortionId { get; set; }

        public List<PortionModel> Portions { get; set; } = new List<PortionModel>();

        public List<FoodMealUserModel> FoodMealUsers { get; set; } = new List<FoodMealUserModel>();

    }
}
