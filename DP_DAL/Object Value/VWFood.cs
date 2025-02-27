using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    [Keyless]
    public class VWFood
    {
        public string UserName { get; set; }
        public string FoodName { get; set; }                /*Burada food name gibi beveragesname de olmalı bunun üzerinden view oluşturudğumuz için
                                                             beveragesview oluşturulurken beveragesname prop yoktu !! */
        public string FoodMealName { get; set; }
        public string PortionName { get; set; }
        public int PortionValue { get; set; }
        public DateOnly UserFoodDate { get; set; }
        public int UserFoodValue { get; set; }
        public int FoodCalorie { get; set; }
        public int UserFoodPortionTotalValue { get; set; } /* Bu kısım Beverages view oluşturulurken comment satırındaydı şimdi açtım!! 
                                                            view i etkileyebilir ?? */
        public int UserFoodCalorie { get; set; }
    }
}
