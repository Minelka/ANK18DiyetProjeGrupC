using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class VwUserTotalCalorieModel
    {
        public string UserName { get; set; }
        public int TotalFoodCalorie { get; set; }
        public int TotalBeveragesCalorie { get; set; }
        public int TotalCalorie => TotalFoodCalorie + TotalBeveragesCalorie;
    }
}
