using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class UserModel : BaseViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public virtual UserInfoModel UserInfo { get; set; }

        public List<FoodMealUserModel> FoodMealUsers { get; set; } = new List<FoodMealUserModel>();

    }
}
