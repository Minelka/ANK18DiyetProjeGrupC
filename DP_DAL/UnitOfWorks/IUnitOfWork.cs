using DP_DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IBeveragesRepository Beverages { get; }
        IFoodMealUserRepository FoodMealUsers { get; }
        IFoodRepository Foods { get; }
        IMealRepository Meals { get; }
        IUserInfoRepository UserInfo { get; }
        IUserRepository User { get; }
        IPortionRepository Portion { get; }
        int Complete();
    }
}
