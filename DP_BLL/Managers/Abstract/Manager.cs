using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DP_DAL.Entities.Abstract;
using DP_DAL.Repository.Abstract;
using DP_DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Managers.Abstract
{
    public abstract class Manager<TModel, TService> : IDisposable, IManager<TModel> where TModel : class
        where TService : IService<TModel>, new()
    {
        private protected readonly TService _service;
        private bool disposed = false;
        

        protected Manager()
        {
            _service = new TService();
        }
        public void Create(TModel model)
        {
            _service.Create(model);
        }

        public void Delete(TModel model)
        {
            _service.Delete(model);
        }

        public ICollection<TModel> GetAll()
        {
            return _service.GetAll();
        }

        public TModel GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(TModel model)
        {
            _service.Remove(model);
        }

        public ICollection<TModel> Search(Expression<Func<TModel, bool>> conditions)
        {
            var results = _service.Search(conditions);
            return results;
        }

        public void Update(TModel model)
        {
            
                _service.Update(model);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _service.Dispose();
                }
            }
            this.disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            return _service.Save();
        }
    }
}
