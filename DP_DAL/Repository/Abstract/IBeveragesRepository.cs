using DP_DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Repository.Abstract
{
    public interface IBeveragesRepository : IRepository<Beverages>,IDisposable
    {
        
    }
}
