using DP_DAL.Entities.Abstract;
using DP_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    public class Beverages : BaseEntity
    {
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int PortionId   { get; set; }

        public virtual Portion Portion { get; set; }

        public virtual ICollection<FoodMealUser> FoodMealUsers { get; set; } = new List<FoodMealUser>();
    }
}
