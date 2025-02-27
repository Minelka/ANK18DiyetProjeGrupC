using DP_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    public class FoodMealUser : BaseEntity
    {
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int MealId { get; set; }

        public virtual Meal Meal { get; set; }

        public int? FoodId { get; set; }

        public virtual Food Food { get; set; }

        public int? BeveragesId { get; set; }

        public virtual Beverages Beverages { get; set; }

        public DateOnly Date { get; set; }

        public int? FoodValue { get; set; }
        public int? BeverageValue { get; set; }
    }
}
