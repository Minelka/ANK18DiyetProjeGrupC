using DP_DAL.Entities.Concrete;
using DP_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public class UserInfoModel: BaseViewModel
    {
        public int UserId { get; set; }
        public virtual UserModel User { get; set; }
        public Gender Gender { get; set; }
        public DateOnly BirthDate { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

    }
}
