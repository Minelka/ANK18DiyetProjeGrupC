using DP_DAL.Entities.Abstract;
using DP_DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    public class UserInfo : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public  Gender Gender { get; set; }
        public DateOnly BirthDate { get; set; }

        [Column(TypeName = "int")] 
        public int Height { get; set; }

        [Column(TypeName = "int")]
        public int Weight { get; set; }

        public virtual ICollection<FoodMealUser> FoodMealUsers { get; set; } = new List<FoodMealUser>();
    }
}
