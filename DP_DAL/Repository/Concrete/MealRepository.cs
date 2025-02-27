using DP_DAL.Data;
using DP_DAL.Entities.Concrete;
using DP_DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Repository.Concrete
{
    public class MealRepository : Repository<Meal>, IMealRepository
    {
        private DbContext _dbcontext;
        private bool disposed = false;
        public MealRepository(DbContext context) : base(context)
        {
            _dbcontext = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
