using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class VwFoodReportModel 
    {
        public string UserName { get; set; }
        public string FoodName { get; set; }                
        public string FoodMealName { get; set; }
        public string PortionName { get; set; }
        public int PortionValue { get; set; }
        public DateOnly UserFoodDate { get; set; }
        public int UserFoodValue { get; set; }
        public int FoodCalorie { get; set; }
        public int UserFoodPortionTotalValue { get; set; }
        public int UserFoodCalorie { get; set; }
    }
}
