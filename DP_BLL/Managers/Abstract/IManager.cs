using DP_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Managers.Abstract
{
    public interface IManager<TModel> where TModel : class
    {
        public void Create(TModel model);
        public void Update(TModel model);

        public void Delete(TModel model); // Soft delete (gerçekten silmeyip, statüyü silindi yapacak)

        public void Remove(TModel model); // Hard delete (gerçekten silecek)

        public ICollection<TModel> GetAll();
        public TModel GetById(int id);

        public ICollection<TModel> Search(Expression<Func<TModel, bool>> conditions);

        int Save();

    }
}
