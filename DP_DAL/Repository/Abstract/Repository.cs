using DP_DAL.Data;
using DP_DAL.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Repository.Abstract
{
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;
        private bool disposed = false;

        protected Repository(DbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
            entity.IsActive = true;
            _entities.Add(entity);
            

        }
        //Kullanıcıdan alınan değeri biz sıfır olarak atayacağız. Admin paneli için user ıd önemli
        public void Update(TEntity entity)
        {
            entity.Modified = DateTime.Now;
            entity.IsActive = true;
            entity.Created = GetById(entity.Id).Created;

            _entities.Update(entity);
            
        }

        public void Delete(TEntity entity)
        {
            entity.Deleted = DateTime.Now;
            entity.IsActive = false;
            Update(entity);
            
        }

        public ICollection<TEntity> GetAll()
        {
            return _entities.AsNoTracking().Where(e => e.Deleted == null).ToList();
        }

        public TEntity GetById(int id)
        {
            return _entities.AsNoTracking().SingleOrDefault(e => e.Id == id);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
            
        }

        public ICollection<TEntity> Search(Expression<Func<TEntity, bool>> conditions)
        {
            return _entities.AsNoTracking().Where(e => e.Deleted == null).Where(conditions.Compile()).ToList();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
