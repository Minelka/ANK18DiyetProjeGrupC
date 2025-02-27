using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class BeveragesService<TModel> : Abstract.Service<TModel,Beverages> where TModel : class
    {
        public BeveragesService() 
        {
            _repository = _unitOfWork.Beverages;
        }
    }
}
