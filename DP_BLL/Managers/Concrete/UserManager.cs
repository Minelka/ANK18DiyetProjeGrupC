﻿using DP_BLL.Managers.Abstract;
using DP_BLL.Models;
using DP_DAL.Data;
using DP_DAL.Entities.Concrete;
using DP_DAL.Repository.Concrete;
using DP_DAL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace DP_BLL.Managers.Concrete
{
    public class UserManager : Manager<UserModel, UserService<UserModel>>
    {
    }
}
