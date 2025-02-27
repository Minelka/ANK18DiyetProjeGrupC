using DP_DAL.Entities.Abstract;
using DP_DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    public class User : BaseEntity
    {
        [Column(TypeName = "nvarchar(25)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Surname { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string Email { get; set; }

        public string Password { get; set; }
        public virtual UserInfo UserInfo { get; set; }

        public UserType UserType { get; set; } = UserType.User;



    }
}
