using DP_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Repository.Abstract
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        public void Create(TEntity entity);
        public void Update(TEntity entity);

        public void Delete(TEntity entity); // Soft delete (gerçekten silmeyip, statüyü silindi yapacak)

        public void Remove(TEntity entity); // Hard delete (gerçekten silecek)

        public ICollection<TEntity> GetAll();
        public TEntity GetById(int id);

        public ICollection<TEntity> Search(Expression<Func<TEntity, bool>> conditions);
        
    }
}
