using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class PortionService<TModel> : Abstract.Service<TModel, Portion> where TModel : class
    {
        public PortionService()
        {
            _repository = _unitOfWork.Portion;
        }
    }
}
