using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class FoodService<TModel> : Abstract.Service<TModel,Food> where TModel : class
    {
        public FoodService()
        {
            _repository = _unitOfWork.Foods;
        }
    }
}
