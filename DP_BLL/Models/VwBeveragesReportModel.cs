using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class VwBeveragesReportModel
    {
        public string UserName { get; set; }
        public string BeveragesName { get; set; }               
        public string BeveragesMealName { get; set; }
        public string PortionName { get; set; }
        public int PortionValue { get; set; }
        public DateOnly UserBeveragesDate { get; set; }
        public int UserBeveragesValue { get; set; }
        public int BeveragesCalorie { get; set; }
        public int UserBeveragesPortionTotalValue { get; set; }
        public int UserBeveragesCalorie { get; set; }

    }
}
