using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using ModelAPI.Repository.IRepository;

namespace ModelAPI.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity GetById(Guid id)
        {
            return _entities.Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate);
        }

        public void Insert(TEntity entity)
        {
       
                _entities.Add(entity);
           
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        protected Repository(ModelContainer dataContext)
        {
            _entities = dataContext.Set<TEntity>();
            _context = dataContext;
        }

        private readonly DbSet<TEntity> _entities;
        private ModelContainer _context;
    }
}