using DP_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<FoodMealUser> FoodMealUsers { get; set; } = new List<FoodMealUser>();
    }
}
