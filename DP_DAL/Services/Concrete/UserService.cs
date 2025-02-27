using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class UserService<TModel> : Abstract.Service<TModel,User> where TModel : class
    {

        public UserService()
        {
            _repository = _unitOfWork.User;
        }
    }
}
