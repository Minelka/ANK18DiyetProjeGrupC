using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    [Keyless]
    public class VWBeverages
    {
        public string UserName { get; set; }
        public string BeveragesName { get; set; }                /*Burada food name gibi beveragesname de olmalı bunun üzerinden view oluşturudğumuz için
                                                             beveragesview oluşturulurken beveragesname prop yoktu !! */
        public string BeveragesMealName { get; set; }
        public string PortionName { get; set; }
        public int PortionValue { get; set; }
        public DateOnly UserBeveragesDate { get; set; }
        public int UserBeveragesValue { get; set; }
        public int BeveragesCalorie { get; set; }
        public int UserBeveragesPortionTotalValue { get; set; } /* Bu kısım Beverages view oluşturulurken comment satırındaydı şimdi açtım!! 
                                                            view i etkileyebilir ?? */
        public int UserBeveragesCalorie { get; set; }
    }
}
