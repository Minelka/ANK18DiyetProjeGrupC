using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class FoodMealUserService<TModel> : Abstract.Service<TModel,FoodMealUser> where TModel : class
    {
        public FoodMealUserService()
        {
            _repository = _unitOfWork.FoodMealUsers;
        }
    }
}
