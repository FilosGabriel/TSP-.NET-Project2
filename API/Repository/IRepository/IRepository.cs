using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ModelAPI.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);
        IList<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}