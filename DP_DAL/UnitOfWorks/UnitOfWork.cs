using DP_DAL.Data;
using DP_DAL.Repository.Abstract;
using DP_DAL.Repository.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _dbcontext;
        private bool disposed = false;

        public UnitOfWork(DbContext context)
        {
            _dbcontext = context;

            Beverages = new BeveragesRepository(_dbcontext);

            FoodMealUsers = new FoodMealUserRepository(_dbcontext);

            Foods = new FoodRepository(_dbcontext);

            Meals = new MealRepository(_dbcontext);

            UserInfo = new UserInfoRepository(_dbcontext);

            User = new UserRepository(_dbcontext);

            Portion = new PortionRepository(_dbcontext);
        }


        public IBeveragesRepository Beverages {  get; private set; }

        public IFoodMealUserRepository FoodMealUsers { get; private set; }

        public IFoodRepository Foods { get; private set; }

        public IMealRepository Meals { get; private set; }

        public IUserInfoRepository UserInfo { get; private set; }

        public IUserRepository User { get; private set; }

        public IPortionRepository Portion { get; private set; }

        public int Complete()
        {
            int affectedRows = _dbcontext.SaveChanges();

            return affectedRows;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                    Beverages.Dispose();
                    FoodMealUsers.Dispose();
                    Meals.Dispose();
                    UserInfo.Dispose();
                    User.Dispose();
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
