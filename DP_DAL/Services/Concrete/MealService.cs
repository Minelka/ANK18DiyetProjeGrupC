using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class MealService<TModel> : Abstract.Service<TModel,Meal> where TModel : class
    {
        public MealService()
        {
            _repository = _unitOfWork.Meals;
        }
    }
}
