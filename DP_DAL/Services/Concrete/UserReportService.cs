using DP_DAL.Data;
using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Services.Concrete
{
    public class UserReportService
    {
        private readonly DPDbContext _dPDbContext;
        public UserReportService()
        {
            _dPDbContext = new DPDbContext();
        }
        public ICollection<VWFood> UserGetAll()
        {
            return _dPDbContext.VwFoods.ToList();
        }

        public ICollection<VWBeverages> UserGetBeverages()
        {
            return _dPDbContext.VwBeverages.ToList();
        }

       
    }
}
