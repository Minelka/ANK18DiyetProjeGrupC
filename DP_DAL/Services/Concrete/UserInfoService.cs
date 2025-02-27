using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class UserInfoService<TModel> : Abstract.Service<TModel,UserInfo> where TModel : class
    {
        public UserInfoService()
        {
            _repository = _unitOfWork.UserInfo;
        }
    }
}
